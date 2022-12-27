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
    public partial class frmCustomDataReport : Form
    {
        private static frmCustomDataReport _instance { get; set; }
        public frmCustomDataReport()
        {
            InitializeComponent();
        }
        public static frmCustomDataReport GetInstance()
        {
            if (_instance == null || _instance.IsDisposed)
                _instance = new frmCustomDataReport();
            _instance.MdiParent = frmMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }

        private void chkCompra_CheckedChanged(object sender, EventArgs e)
        {
            if(chkPurchase.Checked==true)
            {
                dtpPurchaseI.Enabled = false;
                dtpPurchaseF.Enabled = false;
            }
            else
            {
                dtpPurchaseI.Enabled = true;
                dtpPurchaseF.Enabled = true;
            }
        }

        private void chkVencimento_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExpiration.Checked == true)
            {
                dtpExpirationI.Enabled = false;
                dtpExpirationF.Enabled = false;
            }
            else
            {
                dtpExpirationI.Enabled = true;
                dtpExpirationF.Enabled = true;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            frmCustomReport.ComprasFiltradas = MockDatabase.CustomPurchaseExpirationDate(dtpPurchaseI.Value, dtpPurchaseF.Value, dtpExpirationI.Value, dtpExpirationF.Value, chkPurchase.Checked, chkExpiration.Checked);
            this.WindowState = FormWindowState.Minimized;
            if (chkDatePurchase.Checked)
                frmCustomReport.IsCompraChecked = true;
            else
                frmCustomReport.IsCompraChecked = false;
            frmCustomReport.GetInstance().Show();
        }
    }
}
