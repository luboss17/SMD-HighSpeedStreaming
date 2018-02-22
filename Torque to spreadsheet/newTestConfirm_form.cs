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
    public partial class newTestConfirm_form : Form
    {
        public newTestConfirm_form()
        {
            InitializeComponent();
        }

        public bool clearData = false, excelExport = false, certExport = false;

        private void no_btn_Click(object sender, EventArgs e)
        {
            clearData = false;
            excelExport = false;
            certExport = false;
            this.Close();
        }

        private void yes_btn_Click(object sender, EventArgs e)
        {
            clearData = true;
            excelExport = excelExport_chkbox.Checked;
            certExport = exportCertCSV_chkBox.Checked;
            this.Close();
        }
    }
}
