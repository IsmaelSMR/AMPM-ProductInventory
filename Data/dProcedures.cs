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

namespace Data
{
    public class dProcedures
    {
        dConecction Conn = new dConecction();

        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;

        //Method that allows to load data from a table in a DataGridView

        public DataTable loadData(string Table)
        {
            dt = new DataTable("loadData");
            cmd = new SqlCommand("SELECT * FROM " + Table, Conn.OpenConn()); // Agrega un espacio después de "FROM"
            cmd.CommandType = CommandType.Text;

            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dr.Close();
            return dt;
        }

        //Change color between rows in the DataGridView

        public void changeRowColorDataGridView(DataGridView Dgv)
        {
            Dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            Dgv.DefaultCellStyle.BackColor = Color.White;
        }

        //Code generator

        public string codeGenerator(string Table)
        {
            string code = string.Empty;
            int total = 0;

            //cmd = new SqlCommand("SELECT COUNT(*) as registerTotal FROM " + Table, Conn.OpenConn()); // Agrega un espacio después de "FROM"
            cmd = new SqlCommand("SELECT * FROM " + Table, Conn.OpenConn());
            cmd.CommandType = CommandType.Text;

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                total = Convert.ToInt32(dr["registerTotal"]) + 1;
            }
            dr.Close ();

            if (total < 0)
            {
                code = "0000000" + total;
            }

            else if (total > 100)
            {
                code = "000000" + total;
            }
            else if (total > 1000)
            {
                code = "00000" + total;
            }
            else if (total > 10000)
            {
                code = "0000" + total;
            }
            else if (total > 100000)
            {
                code = "000" + total;
            }
            else if (total > 1000000)
            {
                code = "00" + total;
            }
            else if (total > 10000000)
            {
                code = "0" + total;
            }

            Conn.CloseConn();
            return code;

        }

        //Fill combobox
        public void fillComboBox(string Table, string Name, ComboBox xCBox)
        {
            cmd = new SqlCommand("Select * From " + Table, Conn.OpenConn());
            cmd.CommandType= CommandType.Text;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                xCBox.Items.Add(dr["Name"].ToString());
            }
        }

    }
}
