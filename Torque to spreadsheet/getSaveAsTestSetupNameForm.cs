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
    public partial class getSaveAsTestSetupNameForm : Form
    {
        public string testName = "";
        private string[] testNameList;
        public getSaveAsTestSetupNameForm(string[] passedIntestNameList)
        {
            InitializeComponent();
            testNameList = passedIntestNameList;
            error_lbl.Text = "";
        }
        //Call when user want to save and exit
        private void saveClick()
        {
            //Verify testName, if not valid do not procceed
            foreach (string thisTestName in testNameList)
            {
                if (thisTestName == newTestName_txt.Text)
                {
                    error_lbl.Text = "This Test Name is already existed";
                    return;
                }
            }

            //If test Name is valid Pass test Name into testName and close this Form
            testName = newTestName_txt.Text;
            this.Close();
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            saveClick();
        }
        private void cancel()
        {
            testName = "";
            this.Close();
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            cancel();
        }
        private void newTestName_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                saveClick();
            }
            else if (e.KeyCode == Keys.Escape)
                cancel();
        }
    }
}
