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
    public partial class frmRegistrationLot : Form
    {
        private static frmRegistrationLot _instance;
        public frmRegistrationLot()
        {
            InitializeComponent();
            lstPurchases.DataSource = MockDatabase.Purchases;
            lstProducts.DataSource=MockDatabase.Products;
        }
        public static frmRegistrationLot GetInstance()
        {
            if( _instance == null || _instance.IsDisposed)
                _instance = new frmRegistrationLot();
            _instance.MdiParent = frmMain.ActiveForm;
            _instance.WindowState = FormWindowState.Normal;
            return _instance;
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            List<Product> products = new List<Product>();
            try
            {
                products.Add(MockDatabase.FindProductById(Convert.ToInt64(txtCode.Text)));
                lstProducts.DataSource = products;
            }
            catch (Exception)
            {
                products.Clear();
                lstProducts.DataSource = MockDatabase.Products;
            }
        }

        private void txtNome_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                lstProducts.DataSource = MockDatabase.FindProductByPartialName(txtName.Text);
            }
            catch (Exception)
            {
                lstProducts.DataSource = MockDatabase.Products;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Purchase p = new Purchase();
            p.PurchaseDate = dtpPurchase.Value.Date;
            p.ExpirationDate = dtpExpiration.Value.Date;
            p.Quantity = Convert.ToInt16(nudQuantity.Value);
            p.Product = (Product)lstProducts.SelectedItem;
            MockDatabase.Purchases.Add(p);
        }
    }
}
