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
    public partial class FormAddRun : Form
    {
        public static string newRunName = "";
        public FormAddRun()
        {
            InitializeComponent();
            newRunName = "";
            runName_text.KeyDown += RunName_text_KeyDown;
        }

        private void RunName_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                submit();
            else if (e.KeyCode == Keys.Escape)
                cancel();
        }

        private void FormAddRun_Load(object sender, EventArgs e)
        {
            submit_button.Enabled = false;
        }

        private void runName_text_TextChanged(object sender, EventArgs e)
        {
            if (runName_text.TextLength > 0)
                submit_button.Enabled = true;
        }
        private void cancel()
        {
            newRunName = "";
            Close();
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            cancel();
        }
        private void submit()
        {
            if (Form1.checkColumnNameCanBeUsed(runName_text.Text, Form1.singleTable) == false)
                error_label.Text = "Run Name already existed";
            else
            {
                newRunName = runName_text.Text;
                Close();
            }
        }
        private void submit_button_Click(object sender, EventArgs e)
        {
            submit();
        }
    }
}
