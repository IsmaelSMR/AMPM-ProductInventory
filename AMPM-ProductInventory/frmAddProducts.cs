using Domain;
using Entity;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AMPM_ProductInventory
{
    public partial class frmAddProducts : BaseForm
    {
        byte[] imgByte;
        doProcedure Procedure = new doProcedure();
        doProducts Products = new doProducts();
        eProducts Product = new eProducts();
        

        public frmAddProducts()
        {
            InitializeComponent();
        }

        private void CodeGenerator()
        {
            tbCode.Text = "100" + Procedure.generateCode("Productos");
        }

        private void frmAddProducts_Load(object sender, EventArgs e)
        {
            CodeGenerator();
        }

        private void btnExamine_Click(object sender, EventArgs e)
        {
            OpenFileDialog imageSelector = new OpenFileDialog();
            imageSelector.Title = "Seleccionar imagen";

            if( imageSelector.ShowDialog() == DialogResult.OK)
            {
                picPhoto.Image = Image.FromStream(imageSelector.OpenFile());
                MemoryStream memory = new MemoryStream();
                picPhoto.Image.Save(memory, System.Drawing.Imaging.ImageFormat.Png);

                imgByte = memory.ToArray();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        public override bool Save()
        {
            try
            {
                if (tbName.Text == string.Empty || 
                    tbStock.Text == string.Empty || 
                    tbSupplierName.Text == string.Empty || 
                    cbState.Text == string.Empty)
                {
                    MessageBox.Show("Por favor no deje espacios en blanco", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Product.Name = tbName.Text.Trim();
                    Product.Stock = Convert.ToInt32(tbStock.Text.Trim());
                    Product.SupplierName = tbSupplierName.Text.Trim();
                    Product.Code = tbCode.Text.Trim();

                    // Convertir la imagen a una cadena codificada en base64
                    if (picPhoto.Image != null)
                    {
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            picPhoto.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                            Product.ImageUrl = Convert.ToBase64String(memoryStream.ToArray());
                        }
                    }


                    if (bool.TryParse(cbState.Text.Trim(), out bool activeValue))
                    {
                        Product.Active = activeValue;
                    }
                    else
                    {
                        // Manejar el caso en el que el valor no sea válido
                        MessageBox.Show("El valor del estado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Products.CreateProduct(Product);
                    MessageBox.Show("El producto ha sido agregado exitosamente", "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CodeGenerator();
                    Save();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("El producto no fue agregado por: " +  ex.Message, "Agregar producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
