using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using Data;

namespace Domain
{
    public class doProcedure
    {
        dProcedures objProcedure = new dProcedures();

        //Load data

        public DataTable loadData(string Table)
        {
            return objProcedure.loadData(Table);
        }

        //Alternate color
        public void changeRowColorDataGridView(DataGridView Dgv)
        {
            objProcedure.changeRowColorDataGridView(Dgv);
        }

        //Generate code
        public string generateCode(string Table)
        {
            return objProcedure.codeGenerator(Table);
        }

        //fill combobox
        public void fillComboBox(string Table, string Name, ComboBox xCBox)
        {
            objProcedure.fillComboBox(Table, Name, xCBox);
        }

    }
}
