using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Data
{
    public class dProducts
    {
        dConecction Con = new dConecction();

        SqlCommand cmd;

        //Create
        public void CreateProduct(eProducts products)
        {
            cmd = new SqlCommand("spInsertProduct", Con.OpenConn());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Name", products.Name));
            cmd.Parameters.Add(new SqlParameter("@Stock", products.Stock));
            cmd.Parameters.Add(new SqlParameter("@Active", products.Active));
            cmd.Parameters.Add(new SqlParameter("@SupplierId", products.SupplierId));
            cmd.Parameters.Add(new SqlParameter("@ImageUrl", products.ImageUrl));
            cmd.Parameters.Add(new SqlParameter("@Code", products.Code));
            cmd.Parameters.Add(new SqlParameter("@SupplierName", products.Code));


            cmd.ExecuteNonQuery();
            // Close conn
            Con.CloseConn();
        }

        //update
        public void EditProduct(eProducts products)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateProduct", Con.OpenConn()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ProductId", products.ProductId));
                    cmd.Parameters.Add(new SqlParameter("@Name", products.Name));
                    cmd.Parameters.Add(new SqlParameter("@Stock", products.Stock));
                    cmd.Parameters.Add(new SqlParameter("@Active", products.Active));
                    cmd.Parameters.Add(new SqlParameter("@SupplierId", products.SupplierId));
                    cmd.Parameters.Add(new SqlParameter("@ImageUrl", products.ImageUrl));
                    cmd.Parameters.Add(new SqlParameter("@Code", products.Code));
                    cmd.Parameters.Add(new SqlParameter("@SupplierName", products.Code));


                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la actualización del producto: {ex.Message}");
            }
            finally
            {
                Con.CloseConn();
            }
        }

        //View
        public eProducts ViewProduct(int productId)
        {
            eProducts product = null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("spSelectProducts", Con.OpenConn()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ProductId", productId));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            product = new eProducts
                            {
                                ProductId = Convert.ToInt32(reader["ProductId"]),
                                Name = reader["ProductName"].ToString(),
                                Stock = Convert.ToInt32(reader["Stock"]),
                                Active = Convert.ToBoolean(reader["Active"]),
                                SupplierId = Convert.ToInt32(reader["SupplierId"]),
                                ImageUrl = reader["ImageUrl"].ToString(),
                                Code = reader["Code"].ToString(),
                                SupplierName = reader["SupplierName"].ToString() 
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener información del producto: {ex.Message}");
            }
            finally
            {
                Con.CloseConn();
            }

            return product;
        }


        //Delete
        public void DeleteProduct(eProducts products)
        {
            cmd = new SqlCommand("spDeleteProduct", Con.OpenConn());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ProductId", products.ProductId));
            cmd.ExecuteNonQuery();
            Con.CloseConn();
        }

        public void ViewProduct(eProducts products)
        {
            throw new NotImplementedException();
        }
    }
}
