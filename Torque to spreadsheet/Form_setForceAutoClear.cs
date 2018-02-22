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
    public partial class Form_setForceAutoClear : Form
    {
        public float ac_interval = 0;
        public Form_setForceAutoClear()
        {
            InitializeComponent();
            interval_txt.KeyDown += Interval_txt_KeyDown;
        }

        private void Interval_txt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                submit();
            else if (e.KeyCode == Keys.Escape)
                cancel();
        }
        private void cancel()
        {
            ac_interval = 0;
            this.Close();
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            cancel();
        }
        private void submit()
        {
            try
            {
                ac_interval = Single.Parse(interval_txt.Text);
                if (ac_interval <= 0)
                    MessageBox.Show("Interval needs to be a valid positive number", "Invalid Format");
                else
                    this.Close();
            }
            catch
            {
                MessageBox.Show("Auto Clear Interval needs to be in float format. Please reenter.", "Invalid Format");
            }
        }
        private void submit_btn_Click(object sender, EventArgs e)
        {
            submit();
        }
    }
}
