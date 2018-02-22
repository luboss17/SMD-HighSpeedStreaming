using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form_Calibration : Form
    {
        private int testType = 0;//1 for Single Channel Test, 2 for Dual Channel Test
        private Color highColor = Color.Red, lowColor=Color.Yellow;
        private string pointNum_colName, chan1Readings_colName, chan2Readings_colName, target_colName, low_colName, high_colName;//Represent column name of the test Sequence GridView
        private const string AFCW = "As Found-CW", AFCCW = "As Found-CCW", ALCW = "As Left-CW", ALCCW = "As Left-CCW";
        private int dragIndex = -1, dropIndex = -1;
        
        public Form_Calibration()
        {
            InitializeComponent();
            loadFormSettings();
            set_testOrderList();
            eventHandlerCollections();//Set all extra event handlers for all objects
            setGridColName(AFCW_grid);//Set column Name for Test Sequence GridView
        }
        //set all Appearance Setting for all objects in this Form
        private void loadFormSettings()
        {
            label24.BackColor = highColor;
            label27.BackColor = lowColor;

            //Show List of comPort. Todo: Uncomment this line if use this Form_calibration
            //comList_calibration.DataSource = Form1.FSList;

        }

        //Set all extra event handlers for all objects
        private void eventHandlerCollections()
        {
            //Add Event Handler for listbox drag and drop
            this.testOrder_list.MouseDown += this.testOrder_list_MouseDown;
            this.testOrder_list.DragOver += this.testOrder_list_DragOver;
            this.testOrder_list.DragDrop += this.testOrder_list_DragDrop;

            //When New Row is added to Test Data, recheck pass fail color
            AFCW_grid.RowsAdded += AFCW_grid_RowsAdded;
        }
        //Handle drag drop for listbox1
        private void testOrder_list_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.testOrder_list.SelectedItem == null) return;
            dragIndex = testOrder_list.SelectedIndex;
            this.testOrder_list.DoDragDrop(this.testOrder_list.SelectedItem, DragDropEffects.Move);
        }

        private void testOrder_list_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        
        private void AF_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            set_testOrderList();
        }

        private void AL_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            set_testOrderList();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void CW_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            set_testOrderList();
        }

        private void CCW_chkbox_CheckedChanged(object sender, EventArgs e)
        {
            set_testOrderList();
        }

        //Event Handler when new row is added to AFCW_grid
        private void AFCW_grid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            reevaluatePassFailData(ref AFCW_grid);
        }

        //Return a BindingList<string> that has order of Test Sequence
        private BindingList<string> testOrdersCreate()
        {
            BindingList<string> testList=new BindingList<string>();

            if (AF_chkbox.Checked)
            {
                if (CW_chkbox.Checked)
                    testList.Add(AFCW);
                if (CCW_chkbox.Checked)
                    testList.Add(AFCCW);
            }
            if (AL_chkbox.Checked)
            {
                if (CW_chkbox.Checked)
                    testList.Add(ALCW);
                if (CCW_chkbox.Checked)
                    testList.Add(ALCCW);
            }
            return testList;
        }
        private BindingList<string> testList=new BindingList<string>();
        //Assign testOrder_list
        private void set_testOrderList()
        {
            //Create Current List generated from user selections
            testList = testOrdersCreate();

            //Append testList to testOrder_list
            testOrder_list.DataSource=testList;
        }
        
        //Assign list colName from gridView(any 1 of the 4 AFCW_grid etc. would do)
        private void setGridColName(DataGridView thisGrid)
        {
            pointNum_colName = thisGrid.Columns[0].Name;
            chan1Readings_colName = thisGrid.Columns[1].Name;
            chan2Readings_colName = thisGrid.Columns[2].Name;
            target_colName = thisGrid.Columns[3].Name;
            low_colName= thisGrid.Columns[4].Name;
            high_colName = thisGrid.Columns[5].Name;
        }

        //Populate test data,Todo: Delete this button later when populate real data
        private void button14_Click(object sender, EventArgs e)
        {
            AFCW_grid.BorderStyle=BorderStyle.FixedSingle;
            AFCW_grid.Rows.Add(1, 12,null, 10, 9, 11);
            AFCW_grid.Rows.Add(2, 17, null, 20, 18, 22);
            AFCW_grid.Rows.Add(3, 40, null, 40, 36, 44);
        }
        
        private void testOrder_list_DragDrop(object sender, DragEventArgs e)
        {
            Point point = testOrder_list.PointToClient(new Point(e.X, e.Y));
            int index = this.testOrder_list.IndexFromPoint(point);
            if (index < 0) index = this.testOrder_list.Items.Count - 1;
            object data = e.Data.GetData(typeof(string));
            
            dropIndex = index;
            string tempStr = testOrder_list.Items[dragIndex].ToString();
            testList.RemoveAt(dragIndex);
            testList.Insert(dropIndex,tempStr);
        }
        
        //Assign color code for each Data Row of passed in gridview
        private void reevaluatePassFailData(ref DataGridView thisGrid)
        {
            //Todo: MUST DELETE THIS LINE LATER, testType is determined by user after loading test sequence
            testType = 1;

            float ch1Reading=0, ch2Reading=0, target=0, low=0, high=0;
            int passFail = 0;//0=pass,-1=low,1=high

            foreach (DataGridViewRow gridRow in thisGrid.Rows)
            {
                bool floatValid = true;
                
                //Try to get the float value of Reading, target,low, high
                try
                {
                    ch1Reading= Single.Parse(gridRow.Cells[chan1Readings_colName].Value.ToString());
                }
                catch
                {
                    floatValid = false;
                }
                try
                {
                    Single.TryParse(gridRow.Cells[target_colName].Value.ToString(), out target);
                    Single.TryParse(gridRow.Cells[low_colName].Value.ToString(), out low);
                    Single.TryParse(gridRow.Cells[high_colName].Value.ToString(), out high);
                }
                catch { }


                if (testType == 1)
                {//Single Channel test, compare Channel 1 Reading with Target
                    if (floatValid == true)
                    {
                        //If ch1Reading is either = target or ch1Reading is within low and high, then it pass
                        if ((ch1Reading==target) ||
                            ((ch1Reading>low) &&
                             (ch1Reading<high)))
                        {
                            passFail = 0;
                        }
                        else if (ch1Reading < low)//When ch1Reading is low
                        {
                            passFail = -1;
                        }
                        else//when Ch1Reading is high
                        {
                            passFail = 1;
                        }

                        //Assign color code for Reading if it is too high or low
                        if (passFail == -1)
                            gridRow.Cells[chan1Readings_colName].Style.BackColor = lowColor;
                        if (passFail == 1)
                            gridRow.Cells[chan1Readings_colName].Style.BackColor = highColor;
                    }
                }
                if (testType == 2)
                {//Dual Channel Test
                    //Todo: Make sure which Channel reading should be compared with Target then implement

                }
            }
            
        }
    }
}
