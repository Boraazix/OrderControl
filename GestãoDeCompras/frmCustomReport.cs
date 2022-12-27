using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderControl
{
    public partial class frmCustomReport : Form
    {
        private static frmCustomReport _instance { get; set; }
        public static List<Purchase> ComprasFiltradas { get; set; }
        public static Boolean IsCompraChecked { get; set; }
        public frmCustomReport()
        {
            InitializeComponent();
            dgvMain.DataSource = ComprasFiltradas;
            Config();
        }
        public void Config()
        {
            dgvMain.Columns[3].Visible = false;
            if(IsCompraChecked)
                dgvMain.Columns[3].Visible = true;
            dgvMain.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMain.Columns[4].HeaderText = "Expiration Date";
            dgvMain.Columns[3].HeaderText = "Purchase Date";
            dgvMain.Columns[5].HeaderText = "Total (R$)";
        }
        public static frmCustomReport GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new frmCustomReport();
            _instance.MdiParent = frmMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }

        private void VencimentoPersonalizado_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCustomDataReport.GetInstance().WindowState = FormWindowState.Normal;
        }
    }
}
