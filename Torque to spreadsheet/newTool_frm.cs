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
    public partial class newTool_frm : Form
    {
        public string[] nameArr = new string[2];//nameArr contains [tool or model] and [name]
        public static string toolText = "tool",modelText="model";
        private BindingList<string> toolList = new BindingList<string>(), modelList = new BindingList<string>();
        public newTool_frm(BindingList<string> toolList,BindingList<string> modelList)
        {
            InitializeComponent();
            this.toolList = toolList;
            this.modelList = modelList;
            name_txt.KeyDown += Name_txt_KeyDown;
        }

        private void Name_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (name_txt.Text != ""))
                okBtnClick();
            else if (e.KeyCode == Keys.Escape)
                cancel();
        }
        private void cancel()
        {
            nameArr = new string[2];
            this.Close();
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private bool ifOKToAdd(BindingList<string> strList,string newStrToAdd)
        {
            bool okToAdd;
            if ((strList.Contains(newStrToAdd)) || (newStrToAdd==""))
                okToAdd = false;
            else
                okToAdd = true;

            return okToAdd;
        }

        //this method is called when ok button is triggered
        private void okBtnClick()
        {
            const string errorStr = "New Name is invalid or already existed";
            if (tool_radioBtn.Checked)
            {
                if (ifOKToAdd(toolList, name_txt.Text))
                {
                    nameArr[0] = toolText;
                    nameArr[1] = name_txt.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(errorStr);
                }
            }
            else if (model_radioBtn.Checked)
            {
                if (ifOKToAdd(modelList, name_txt.Text))
                {
                    nameArr[0] = modelText;
                    nameArr[1] = name_txt.Text;
                    this.Close();
                }
                else
                    MessageBox.Show(errorStr);
            }
        }
        private void ok_btn_Click(object sender, EventArgs e)
        {
            okBtnClick();
        }
    }
}
