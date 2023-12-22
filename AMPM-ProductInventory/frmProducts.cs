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
    public partial class frmProducts : BaseForm
    {
        public frmProducts()
        {
            InitializeComponent();
        }

        doProcedure Procedure = new doProcedure();


        private void frmProducts_Load(object sender, EventArgs e)
        {
            LoadData();

            dgvProducts.Columns[0].Visible= false; //Id
            dgvProducts.Columns[4].Visible= false; //SuppId
            dgvProducts.Columns[5].Visible= false; //ImgUrl

            dgvProducts.Columns[1].Width = 145; //Name
            dgvProducts.Columns[2].Width = 145; //Stock
            dgvProducts.Columns[3].Width = 145; //Active
            dgvProducts.Columns[6].Width = 145; //Code
            dgvProducts.Columns[7].Width = 145; //Code


            dgvProducts.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProducts.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProducts.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProducts.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProducts.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;




        }

        private void LoadData()
        {
            dgvProducts.DataSource = Procedure.loadData("Products");

            //dgvProducts.ClearSelection();
        }

       private void AddProduct_EventHandler(object sender, frmAddProducts args)
        {
            LoadData();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddProducts products = new frmAddProducts();
            products.ShowDialog(); 
        }
    }
}
