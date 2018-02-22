using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication1
{
    public partial class FormAddDualRun : Form
    {
        public string newRunName = "";
        public string chan1Name = "";
        public string chan2Name = "";
        public bool allNamesValid = false;
        public FormAddDualRun()
        {
            InitializeComponent();
            runNameText.KeyDown += RunNameText_KeyDown;
            chan1NameText.KeyDown += Chan1NameText_KeyDown;
            chan2NameText.KeyDown += Chan2NameText_KeyDown;
        }

        private void Chan2NameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                submit();
            else if (e.KeyCode == Keys.Escape)
                cancel1();
        }

        private void Chan1NameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                submit();
            else if (e.KeyCode == Keys.Escape)
                cancel1();
        }

        private void RunNameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                submit();
            else if (e.KeyCode == Keys.Escape)
                cancel1();
        }

        private void FormAddDualRun_Load(object sender, EventArgs e)
        {
            chan1Name_Label.Text = "Channel 1 label: \n(default to Run Name-CH1\n if leave blank)";
            chan2Name_Label.Text = "Channel 2 label: \n(default to Run Name-CH2\n if leave blank)";
            resetErrorLabels();
            submit_btn.Enabled = false;
        }

        private void resetErrorLabels()
        {
            runNameError.Text = "";
            Chan1NameError.Text = "";
            Chan2NameError.Text = "";
        }
        private void runNameText_TextChanged(object sender, EventArgs e)
        {
            if (runNameText.Text.Length > 0)
                submit_btn.Enabled = true;
        }
        private void cancel1()
        {
            newRunName = "";
            Close();
        }
        
        private void submit()
        {
            //Todo: check chan1Name and chan2Name unique among dualTable ColumnName, newRunName is unique among dualChart Series. And ONLY newRunName non-empty
            const string runName_err = "This Run Name has already been used";
            const string chanName_err = "This Channel Name has already been used";
            allNamesValid = true;

            resetErrorLabels();

            //Assign newRunName, this is used for naming the new Serie in dualChart
            if (runNameText.Text.Length > 0)
                newRunName = runNameText.Text;
            else
            {
                runNameError.Text = "This field can not be empty";
            }

            //Assign name for channel1 
            if (chan1NameText.Text.Length == 0)
            {
                chan1Name = newRunName + "-CH1";
                chan1NameText.Text = chan1Name;
            }
            else
            {
                chan1Name = chan1NameText.Text;
            }

            //Assign name for channel2
            if (chan2NameText.Text.Length == 0)
            {
                chan2Name = newRunName + "-CH2";
                chan2NameText.Text = chan2Name;
            }
            else
            {
                chan2Name = chan2NameText.Text;
            }

            //Check if name for chan1Name,chan2Name and runName can be used
            if (Form1.checkColumnNameCanBeUsed(chan1Name, Form1.dualTable) == false)
            {
                chan1Name = "";
                Chan1NameError.Text = chanName_err;
                allNamesValid = false;
            }
            if (Form1.checkColumnNameCanBeUsed(chan2Name, Form1.dualTable) == false)
            {
                chan2Name = "";
                Chan2NameError.Text = chanName_err;
                allNamesValid = false;
            }
            if (Form1.checkSerieNameCanBeUsed(newRunName, Form1.arr_dualSeries) == false)
            {
                newRunName = "";
                runNameError.Text = runName_err;
                allNamesValid = false;
            }

            if (allNamesValid == true)
                Close();
        }
        private void submit_Click(object sender, EventArgs e)
        {
            submit();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            cancel1();
        }
    }
}
