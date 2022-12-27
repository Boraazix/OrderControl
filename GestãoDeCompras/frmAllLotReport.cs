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
    public partial class frmAllLotReport : Form
    {
        private static frmAllLotReport _instance { get; set; }
        public static frmAllLotReport GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new frmAllLotReport();
            _instance.MdiParent = frmMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }
        public frmAllLotReport()
        {
            InitializeComponent();
            dgvMain.DataSource = MockDatabase.Purchases;
            Config();
        }
        public void Config()
        {
            dgvMain.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvMain.Columns[3].Visible = false;
            dgvMain.Columns[4].HeaderText = "Expiration Date";
            dgvMain.Columns[5].HeaderText = "Total (R$)";
        }
    }
}
