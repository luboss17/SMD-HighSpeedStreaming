using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormRename : Form
    {
        public string newName="";
        public string oldName="";
        public int columnIndex = 0;
        public FormRename()
        {
            InitializeComponent();
            newName_text.KeyDown += NewName_text_KeyDown;
        }

        private void NewName_text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                submit();
            else if (e.KeyCode == Keys.Escape)
                cancel();
        }

        private void runNameList_Init(DataTable table)
        {
            submit_button.Enabled = false;
            runNameList.Items.Clear();
            int count = 0;
            foreach (DataColumn column in table.Columns)
            {
                if (count>0)
                    runNameList.Items.Add(column.ColumnName);
                count++;
            }
        }
        private void Form_Rename_Load_1(object sender, EventArgs e)
        {
            runNameList_Init(Form1.singleTable);
        }
        private void cancel()
        {
            columnIndex = 0;
            newName = "";
            Close();
        }
        private void cancel_button_Click(object sender, EventArgs e)
        {
            cancel();
        }

        private void checkSubmit()
        {
            if ((newName_text.TextLength > 0) && (runNameList.SelectedIndex > -1))
            {
                submit_button.Enabled = true;
            }
            else
            {
                submit_button.Enabled = false;
            }
        }
        private void submit()
        {
            if (Form1.checkColumnNameCanBeUsed(newName_text.Text, Form1.singleTable) == false)
                error_label.Text = "Run Name needs to be unique";
            else
            {
                columnIndex = runNameList.SelectedIndex + 1;
                oldName = runNameList.SelectedItem.ToString();
                newName = newName_text.Text;
                Close();
            }
        }
        private void submit_button_Click(object sender, EventArgs e)
        {
            submit();
        }

        private void newName_text_TextChanged(object sender, EventArgs e)
        {
            checkSubmit();
        }

        private void runNameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkSubmit();
        }
    }
}
