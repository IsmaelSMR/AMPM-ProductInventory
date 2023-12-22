using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Entity;

namespace AMPM_ProductInventory
{
    public partial class frmLogging : Form
    {
        public frmLogging()
        {
            InitializeComponent();
        }

        doUsers Users = new doUsers();
        eUsers User = new eUsers();

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void fmrLogin_Load(object sender, EventArgs e)
        {

        }

        private void agregarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser products = new frmAddUser();
            products.ShowDialog();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmPrincipal products = new frmPrincipal();
            products.ShowDialog();
        }

        

        private void btnLogging_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbUsername.Text != string.Empty)
                {
                    if (tbPassword.Text != string.Empty)
                    {

                        User.Username1 = tbUsername.Text;
                        User.Password1 = tbPassword.Text;

                        

                        if (true)
                        {
                            frmPrincipal products = new frmPrincipal();
                            products.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrecto, por favor intente nuevamente",
                                "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            tbUsername.Clear();
                            tbPassword.Clear();
                            tbUsername.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe completar el campo contraseña", "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        tbUsername.Clear();
                        tbPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar el campo usuario", "Ingreso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    tbUsername.Focus();
                }
            }
            catch
            {

            }

            /*frmPrincipal products = new frmPrincipal();
            products.ShowDialog();
            this.Close();*/
        }
    }
}
