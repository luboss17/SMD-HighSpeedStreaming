using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form_ToolsManager : Form
    {
        public Client pack;
        private DataTable toolsTable;
        private DataTable modelsTable;
        DataTable toolsModelsTable;
        BindingList<string> bindingListToShow = new BindingList<string>();
        public List<TestSetup> testSetups;
        DataTable toolCondTable;
        private const string toolText = "Tool", modelText = "Model";
        private string[] toolSearchSubject_showUser = new string[] { "Tool ID", "Serial Number", "Model", "Equipment", "Manufacture", "Lot ID", "Test ID" };
        private string[] toolSearchSubject_matchTable;
        string[] testIDStr_arr;//contains list of testID
        public Form_ToolsManager(Client passedinPack, List<TestSetup> testSetups)
        {
            //Todo: return pack and testSetups back to Form1 after done w this form
            InitializeComponent();
            pack = passedinPack;
            this.testSetups = testSetups;
            getToolsModelTable(pack);
            toolCondTable = toolsTable.Clone();//default toolcondtable to Tools table first
            if (toolCondTable.Rows.Count == 0)
                toolCondTable.Rows.Add();

            //assign list of testID
            getTestIDList();
            toolsModel_comboBox.SelectedIndex = 0;
            //Show the search subject to user
            searchSubject_comboBox.DataSource = toolSearchSubject_showUser;

            //Assign colName of tool field(follow same order as toolSearchSubject_showUser)
            toolSearchSubject_matchTable = new string[] { pack.toolID_colName, pack.SN_colName, pack.model_colName, pack.equipment_colName, pack.manufacturer_colName, pack.lotID_colName, pack.testID_colName };
        }

        //Assign testIDStr_arr to testID_comboBox
        private void getTestIDList()
        {

            testIDStr_arr = Form1.get_listOfTestName(testSetups);
            testID_comboBox.Items.Clear();
            testID_comboBox.Items.Add("New");
            testID_comboBox.Items.AddRange(testIDStr_arr);

        }
        //Fill in toolsTable and modelsTable
        //changed 10/6/17
        private void getToolsModelTable(Client pack)
        {
            pack.obj = "tools";
            pack.conditions = new DataTable();
            pack.sendCommand("find");

            //If result table has more than 1 row from find command then copy resultable to toolsModelsTable
            //if not, just clone tools table structure from Client
            if (pack.resultTable.Rows.Count > 0)
                toolsModelsTable = pack.resultTable.Copy();
            else
                toolsModelsTable = pack.tools.Clone(); //default to tools Table for now, since we are not supporting model table yet
            

            //Clone the structure of toolsTable and modelTable
            toolsTable = toolsModelsTable.Clone();
            modelsTable = toolsModelsTable.Clone();

            updateToolsModelTable(toolsModelsTable);//separate tools and models to 2 tables

        }
        //update toolsTable and modelsTable
        private void updateToolsModelTable(DataTable toolsAndModelTable)
        {
            foreach (DataRow tableRow in toolsAndModelTable.Rows)
            {
                //if toolID is null, copy to Model table
                if (tableRow[pack.toolID_colName].ToString() == "")
                {
                    modelsTable.ImportRow(tableRow);
                }
                else
                    toolsTable.ImportRow(tableRow);

            }
        }
        //Return BindingList<string> that contains list of toolID
        private BindingList<string> getToolsList(DataTable thisTable, string colName)
        {
            BindingList<string> returnToolsList = new BindingList<string>();
            try
            {
                //Assign whole column of data into returnToolsList
                returnToolsList = new BindingList<string>(thisTable.Rows.OfType<DataRow>().Select(dr => dr.Field<string>(colName)).ToList());

            }
            catch { MessageBox.Show("Unable to get list of Tools"); }

            return returnToolsList;
        }

        private void toolDelete_btn_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you sure you want to delete selecting Tool?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                pack.toolIDToDelete = searchResult_listBox.SelectedItem.ToString();
                pack.obj = "tool";
                pack.sendCommand("delete");

                getToolsModelTable(pack);

                bindListTocomboBox();
            }
        }

        //bind bindingListToShow to toolsModel_combobox
        private void bindListTocomboBox()
        {
            int lastSelectIndex = searchResult_listBox.SelectedIndex;
            toolID_txt.Enabled = false;
            if (toolsModel_comboBox.Text == toolText)
            {
                bindingListToShow = getToolsList(toolsTable, pack.toolID_colName);
            }
            else if (toolsModel_comboBox.Text == modelText)
            {
                bindingListToShow = getToolsList(modelsTable, pack.model_colName);
            }
            searchResult_listBox.DataSource = bindingListToShow;
            try
            {
                searchResult_listBox.SelectedIndex = lastSelectIndex;
            }
            catch { }
        }
        private void toolsModel_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchField_txt.Text = "";
            bindListTocomboBox();
        }

        //Convert passedinInt to true(int=1) or false (any other value)
        private Boolean convertIntToBool(string passedInInt)
        {
            bool returnBool = false;
            if (passedInInt == "1")
                returnBool = true;

            return returnBool;
        }

        //convert false to 0, true to 1
        private int convertBoolToInt(Boolean boolValue)
        {
            int returnInt = 0;
            if (boolValue == true)
                returnInt = 1;
            return returnInt;
        }

        //passed in value from mode_column in ToolTable, return the index that mode_comboBox need to select
        //0: Track
        //1: Peak
        //2: 1st Peak
        //3: Trough
        private int getModeIndexfromTable(string indexStr)
        {
            int modeIndex = -1;
            switch (indexStr)
            {
                case "0":
                    modeIndex = 0;
                    break;
                case "1":
                    modeIndex = 1;
                    break;
                case "2":
                    modeIndex = 2;
                    break;
                case "3":
                    modeIndex = 3;
                    break;
            }
            return modeIndex;
        }
        string currTestID = "";
        //load the tool that match the value from passed in table and colName.
        //use offset in case there are more than 1 values in table column that match the IDtoCompare
        private void loadToolorModel(DataTable thisTable, string colName, string IDtoCompare, int offset)
        {
            currTestID = "";
            foreach (DataRow tableRow in thisTable.Rows)
            {
                if (tableRow[colName].ToString() == IDtoCompare)
                {
                    if (offset <= 0)
                    {
                        toolID_txt.Text = tableRow[pack.toolID_colName].ToString();
                        model_txt.Text = tableRow[pack.model_colName].ToString();
                        equipment_txt.Text = tableRow[pack.equipment_colName].ToString();
                        manufacture_txt.Text = tableRow[pack.manufacturer_colName].ToString();
                        SN_txt.Text = tableRow[pack.SN_colName].ToString();
                        lotID_txt.Text = tableRow[pack.lotID_colName].ToString();
                        ch1Mode_comboBox.SelectedIndex = getModeIndexfromTable(tableRow[pack.mode_colName].ToString());
                        ch2Mode_comboBox.SelectedIndex = getModeIndexfromTable(tableRow[pack.imode_colName].ToString());
                        scanOperator_chk.Checked = convertIntToBool(tableRow[pack.scanOperator_colName].ToString());
                        scan1_chk.Checked = convertIntToBool(tableRow[pack.scan1_colName].ToString());
                        scan2_chk.Checked = convertIntToBool(tableRow[pack.scan2_colName].ToString());
                        pauseTool_chk.Checked = convertIntToBool(tableRow[pack.setupPause_colName].ToString());

                        //Assign the name of test associated with this tool or model
                        currTestID = tableRow[pack.testID_colName].ToString();

                        //import this toolRow into toolCondTable
                        toolCondTable = thisTable.Clone();
                        toolCondTable.ImportRow(tableRow);

                        break;
                    }
                    else
                        offset--;
                }
            }
        }
        //find the index of passed in testID and select that test
        private void loadTest(string testID)
        {
            int testIndex = Array.IndexOf(testIDStr_arr, testID);
            testID_comboBox.SelectedIndex = testIndex + 1;
        }

        //offset the index of the same selected text that occured before the selected index in searchResult_listbox
        private int offsetSameSearchName()
        {
            int offsetReturn = 0;
            int selectedIndex = searchResult_listBox.SelectedIndex;
            string selectedItem = searchResult_listBox.SelectedItem.ToString();
            for (int runningIndex = selectedIndex - 1; runningIndex >= 0; runningIndex--)
            {
                if (searchResult_listBox.Items[runningIndex].ToString() == selectedItem)
                {
                    offsetReturn++;
                }
            }

            return offsetReturn;
        }

        bool isChangeMade = false;//Determine whether a change has been made. If yes, make sure ask to save first
        private void tools_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string colName = "";
            if ((isChangeMade == false) && (searchResult_listBox.SelectedIndex >= 0))
            {
                if (toolsModel_comboBox.Text == toolText)
                {
                    colName = toolSearchSubject_matchTable[searchSubject_comboBox.SelectedIndex];
                    int offset = offsetSameSearchName();
                    loadToolorModel(toolsTable, colName, searchResult_listBox.SelectedItem.ToString(), offset);

                }//Right now model is not supported, so it won't ever go into this else
                else if (toolsModel_comboBox.Text == modelText)
                {
                    colName = pack.model_colName;
                    int offset = offsetSameSearchName();
                    loadToolorModel(modelsTable, colName, searchResult_listBox.SelectedItem.ToString(), offset);
                }

                //Todo: Load the test
                loadTest(currTestID);

            }
            else
            {
                //Todo: Implement case when the last Tool has not been saved yet. Should ask to save first before proceed

            }
        }

        //when user select new test, clear all fields
        private void newTestReset()
        {
            testType_comboBox.SelectedIndex = 0;
            maxPoint_txt.Text = "";
            FS_txt.Text = "";
            sampleNum_txt.Text = "1";
            lowLimit_txt.Text = "";
            highLimit_txt.Text = "";
            limitEngPercent_comboBox.SelectedIndex = 0;
        }
        //Trigger when new Tool/Model button is pressed
        //Clear all the tool field and test field
        private void newToolReset()
        {
            toolID_txt.Text = "";
            model_txt.Text = "";
            equipment_txt.Text = "";
            manufacture_txt.Text = "";
            SN_txt.Text = "";
            lotID_txt.Text = "";
            scanOperator_chk.Checked = false;
            scan1_chk.Checked = false;
            scan2_chk.Checked = false;
            pauseTool_chk.Checked = false;
            newTestReset();
        }
        //Load test 
        private void initCurrTestSetup(int testIndex)
        {
            TestSetup thisTestSetup = testSetups[testIndex];

            try
            {
                testType_comboBox.SelectedIndex = Int32.Parse(thisTestSetup.testType) - 1;
            }
            catch
            {
                testType_comboBox.SelectedIndex = 0;
            }
            FS_txt.Text = thisTestSetup.FullScale;
            lowLimit_txt.Text = thisTestSetup.low;
            highLimit_txt.Text = thisTestSetup.high;
            maxPoint_txt.Text = thisTestSetup.pointAmount;

        }

        private void testID_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (testID_comboBox.SelectedIndex > 0) //User select 1 of the saved Test
            {
                int testIndex = testID_comboBox.SelectedIndex - 1;
                initCurrTestSetup(testIndex);

            }
            else if (testID_comboBox.SelectedIndex == 0) //New Test is selected
            {
                newTestReset();
            }
        }

        /// <summary>
        /// Update or insert new tool, passed in toolID and modelID(if toolID is empty, meaning save as new model) and command("update" or "insert")
        /// </summary>
        /// <param name="toolID">if null that means save as model</param>
        /// <param name="modelID"></param>
        /// <param name="command">either "insert" or "update"</param>
        private void updateOrInsertTool(string toolID, string modelID, string command)
        {
            try
            {
                //Save all the fields into toolCondTable
                toolCondTable.Rows[0][pack.toolID_colName] = toolID;
                toolCondTable.Rows[0][pack.model_colName] = modelID;
                toolCondTable.Rows[0][pack.equipment_colName] = equipment_txt.Text;
                toolCondTable.Rows[0][pack.manufacturer_colName] = manufacture_txt.Text;
                toolCondTable.Rows[0][pack.SN_colName] = SN_txt.Text;
                toolCondTable.Rows[0][pack.lotID_colName] = lotID_txt.Text;
                toolCondTable.Rows[0][pack.scanOperator_colName] = convertBoolToInt(scanOperator_chk.Checked);
                toolCondTable.Rows[0][pack.scan1_colName] = convertBoolToInt(scan1_chk.Checked);
                toolCondTable.Rows[0][pack.scan2_colName] = convertBoolToInt(scan2_chk.Checked);
                toolCondTable.Rows[0][pack.setupPause_colName] = convertBoolToInt(pauseTool_chk.Checked);
                toolCondTable.Rows[0][pack.testID_colName] = testID_comboBox.Text;
                toolCondTable.Rows[0][pack.mode_colName] = ch1Mode_comboBox.SelectedIndex;
                toolCondTable.Rows[0][pack.imode_colName] = ch2Mode_comboBox.SelectedIndex;
                pack.obj = "tool";
                pack.conditions = toolCondTable.Copy();
                pack.sendCommand(command);

                //Todo: update ToolList again, call getToolModelTable
                getToolsModelTable(pack);

                bindListTocomboBox();
                //assign list of testID
                getTestIDList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to Save this Tool due to error: " + e.Message, "Error");
            }
        }

        private void saveTool_btn_Click(object sender, EventArgs e)
        {
            if (toolsModel_comboBox.Text == toolText)
            {
                if (searchResult_listBox.SelectedIndex >= 0)
                {
                    if (toolID_txt.Text != "")
                        updateOrInsertTool(toolID_txt.Text, model_txt.Text, "update");
                }
                else//Save as new
                {
                    string toolID = toolID_txt.Text;
                    string model = model_txt.Text;
                    updateOrInsertTool(toolID, model, "insert");
                }
            }
        }

        private void saveAsTool_btn_Click(object sender, EventArgs e)
        {
            newTool_frm newToolForm = new newTool_frm(getToolsList(toolsTable, pack.toolID_colName), getToolsList(modelsTable, pack.model_colName));
            newToolForm.ShowDialog();
            string toolID = "", modelID = "";
            if (newToolForm.nameArr[1] != "")
            {//if name is not empty, save the current test under new toolID/model
                if (newToolForm.nameArr[0] == newTool_frm.toolText)//Save Tool
                {
                    toolID = newToolForm.nameArr[1];
                    modelID = model_txt.Text;
                }
                else if (newToolForm.nameArr[0] == newTool_frm.modelText)//Save Model
                {
                    modelID = newToolForm.nameArr[1];
                }
                updateOrInsertTool(toolID, modelID, "insert");
            }
        }

        private void newTool_btn_Click(object sender, EventArgs e)
        {
            newToolReset();
            searchResult_listBox.SelectedIndex = -1;
            if (toolsModel_comboBox.Text == toolText)
                toolID_txt.Enabled = true;
        }

        private void testManager_btn_Click(object sender, EventArgs e)
        {
            string prev_testID;
            if (testID_comboBox.SelectedIndex >= 0)
                prev_testID = testID_comboBox.SelectedItem.ToString();
            else
                prev_testID = testID_comboBox.Items[0].ToString();
            TestSequenceManager_form frm = new TestSequenceManager_form(testSetups);
            frm.ShowDialog();

            if (frm.isTestSetupSaved)
                testSetups = frm.testSetups;

            //reassign list of testID
            getTestIDList();

            //attempt to reselect the testID
            try
            {
                foreach (var testID_comboItem in testID_comboBox.Items)
                {
                    if (testID_comboItem.ToString() == prev_testID)
                        testID_comboBox.SelectedItem = testID_comboItem;
                }
            }
            catch
            {
                testID_comboBox.SelectedIndex = 0;
            }
        }

        private void searchSubject_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateToolSearchResult();
        }

        //update result when search field is changed
        private void updateToolSearchResult()
        {
            searchResult_listBox.SelectedIndex = -1;
            BindingList<string> oriList = new BindingList<string>();
            BindingList<string> listToShow = new BindingList<string>();
            /*Uncomment this part because temporarily not support model
            //Assign list of tool or model to oriList
            if (toolsModel_comboBox.Text == toolText)
            {
                oriList = getToolsList(toolsTable, pack.toolID_colName);
            }
            else if (toolsModel_comboBox.Text == modelText)
            {
                oriList = getToolsList(modelsTable, pack.model_colName);
            }
            */

            //assign original list of tool based on the search subject
            oriList = getToolsList(toolsTable, toolSearchSubject_matchTable[searchSubject_comboBox.SelectedIndex]);

            if (searchField_txt.Text != "")
            {
                //Search for the tool or model that match the search text only, then add to listToshow
                foreach (string itemFound in oriList)
                {
                    if (itemFound.Contains(searchField_txt.Text))
                        listToShow.Add(itemFound);
                }
            }
            else//if search is empty, show all the tool from oriList
            {
                listToShow = oriList;
            }

            //bind listToShow to tools_listbox
            searchResult_listBox.DataSource = listToShow;
        }


        private void ch1Mode_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if both ch1mode and ch2mode is trough. Change the other to track
            if ((ch1Mode_comboBox.SelectedIndex == 3) && (ch2Mode_comboBox.SelectedIndex == 3))
            {
                ch2Mode_comboBox.SelectedIndex = 0;
            }
        }

        private void ch2Mode_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if both ch1mode and ch2mode is trough. Show notification
            if ((ch1Mode_comboBox.SelectedIndex == 3) && (ch2Mode_comboBox.SelectedIndex == 3))
            {
                ch1Mode_comboBox.SelectedIndex = 0;
            }
        }

        private void toolSearch_txt_TextChanged(object sender, EventArgs e)
        {
            updateToolSearchResult();
        }
    }
}
