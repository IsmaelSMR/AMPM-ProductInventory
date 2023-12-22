using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMPM_ProductInventory
{
    public partial class frmPrincipal : BaseForm
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tmTime_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
            lbDate.Text = DateTime.Now.ToLongDateString();
        }

        private void lbDate_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmProducts products = new frmProducts();
            products.ShowDialog();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEditUsers users = new frmEditUsers();
            users.ShowDialog();
        }
    }
}
