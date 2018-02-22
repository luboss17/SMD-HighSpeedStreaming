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
    public partial class Form_DualRename : Form
    {
        public string newRunName = "", chan1Name = "", chan2Name = "",oldRunName="";
        private BindingSource runNameSource=new BindingSource();
        public Form_DualRename()
        {
            InitializeComponent();
            newRunName_text.KeyDown += NewRunName_text_KeyDown;
            newChan1NameText.KeyDown += NewChan1NameText_KeyDown;
            newChan2NameText.KeyDown += NewChan2NameText_KeyDown;
        }

        private void NewChan2NameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                submit();
            else if (e.KeyCode == Keys.Escape)
                cancel();
        }

        private void NewChan1NameText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                submit();
            else if (e.KeyCode == Keys.Escape)
                cancel();
        }

        private void NewRunName_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                submit();
            else if (e.KeyCode == Keys.Escape)
                cancel();
        }

        private void bindRunNameList()
        {
            runNameSource.DataSource = Form1.arr_dualSeries;
            runNameList.DataSource = runNameSource;
        }

        private void enableSubmitButton()
        {
            if ((newRunName_text.Text != "") || (newChan1NameText.Text != "") || (newChan2NameText.Text != ""))
                submit_button.Enabled = true;
            else
            {
                submit_button.Enabled = false;
            }
        }
        private void newRunName_text_TextChanged(object sender, EventArgs e)
        {
            enableSubmitButton();
        }

        private void newChan1NameText_TextChanged(object sender, EventArgs e)
        {
            enableSubmitButton();
        }

        private void newChan2NameText_TextChanged(object sender, EventArgs e)
        {
            enableSubmitButton();
        }
        private void cancel()
        {
            newRunName = "";
            chan1Name = "";
            chan2Name = "";
            Close();
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void Form_DualRename_Load(object sender, EventArgs e)
        {
            resetError();
            submit_button.Enabled = false;
            bindRunNameList();
        }
        
        private void resetError()
        {
            error_runName.Text = "";
            error_chan1.Text = "";
            error_chan2.Text = "";
        }

        private bool checkRunName(string runName)
        {
            foreach (var name in Form1.arr_dualSeries)
            {
                if (runName == name)
                {
                    error_runName.Text = "This Run Name is already existed";
                    return false;
                }
            }
            return true;
        }

        private bool checkColName(string colName,ref Label thisLabel)
        {
            foreach (DataColumn column in Form1.dualTable.Columns)
            {
                if (column.ColumnName == colName)
                {
                    thisLabel.Text = "This channel name is already existed";
                    return false;
                }
            }
            return true;
        }
        private void submit()
        {
            resetError();
            oldRunName = runNameList.SelectedItem.ToString();
            newRunName = newRunName_text.Text;
            chan1Name = newChan1NameText.Text;
            chan2Name = newChan2NameText.Text;

            if (checkRunName(newRunName) && checkColName(chan1Name, ref error_chan1) && checkColName(chan2Name, ref error_chan2))
                Close();
        }
        //Todo: check if the runName already existed in arr_dualSeries
        //Todo: check if chan1Name and chan2Name already existed in dualTable
        private void submit_button_Click(object sender, EventArgs e)
        {
            submit();
            
        }
    }
}
