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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual bool Save()
        {
            return false;
        }
        public virtual void Edit()
        {

        }
        public virtual void Delete()
        {

        }
        public virtual void View()
        {

        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
