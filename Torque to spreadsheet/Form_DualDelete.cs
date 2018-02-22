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
    public partial class Form_DualDelete : Form
    {
        public string deleteSerie = "";
        public Form_DualDelete()
        {
            InitializeComponent();
        }
        private void runNameList_Init(List<string> serieList)
        {
            delete_button.Enabled = false;
            runNameList.Items.Clear();
            int count = 0;

            foreach (String serie in serieList)
            {
                if (count < (serieList.Count - 1))
                    runNameList.Items.Add(serie);
                count++;
            }
        }
        //Todo: this is wrong, need to pass in Serie list, not dualtable list
        private void Form_DualDelete_Load(object sender, EventArgs e)
        {

            runNameList_Init(Form1.arr_dualSeries);
        }

        private void runNameList_SelectedIndexChanged(object sender, EventArgs e)
        {
            const int minIndex = 0;
            if (runNameList.SelectedIndex >= minIndex)
                delete_button.Enabled = true;
            else
            {
                delete_button.Enabled = false;
            }
        }
        
        private void delete_button_Click(object sender, EventArgs e)
        {
            deleteSerie = runNameList.SelectedItem.ToString();
            Close();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            deleteSerie = "";
            Close();
        }
    }
}
