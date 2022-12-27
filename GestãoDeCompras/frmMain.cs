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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout.GetInstance().Show();
        }

        private void novoLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrationLot.GetInstance().Show();
        }

        private void todosOsLotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllLotReport.GetInstance().Show();
        }

        private void aVencerEmAtéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpiresOneDayReport.GetInstance().Show();
        }

        private void aVencerEmAté5DiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpiresFiveDaysReport.GetInstance().Show();
        }

        private void vencimentoPersonalizadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomDataReport.GetInstance().Show();
        }
    }
}
