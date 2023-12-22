using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class dUsers
    {

        dConecction Con = new dConecction();

        SqlCommand cmd;

        //Create
        public void CreateUser(eUsers Users)
        {
            cmd = new SqlCommand("spInserUser", Con.OpenConn());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Username", Users.Username1));
            cmd.Parameters.Add(new SqlParameter("@Password", Users.Password1));
            cmd.Parameters.Add(new SqlParameter("@FirstName", Users.FirstName1));
            cmd.Parameters.Add(new SqlParameter("@LastName", Users.LastName1));
            cmd.Parameters.Add(new SqlParameter("@Email", Users.Email1));
            cmd.Parameters.Add(new SqlParameter("@Phone", Users.PhoneNumber1));

            cmd.ExecuteNonQuery();
            // Close conn
            Con.CloseConn();
        }

        //Update
        public void EditUser(eUsers Users)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateUser", Con.OpenConn()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Id", Users.Id1));
                    cmd.Parameters.Add(new SqlParameter("@Username", Users.Username1));
                    cmd.Parameters.Add(new SqlParameter("@Password", Users.Password1));
                    cmd.Parameters.Add(new SqlParameter("@FirstName", Users.FirstName1));
                    cmd.Parameters.Add(new SqlParameter("@LastName", Users.LastName1));
                    cmd.Parameters.Add(new SqlParameter("@Email", Users.Email1));
                    cmd.Parameters.Add(new SqlParameter("@Phone", Users.PhoneNumber1));

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la actualización del usuario: {ex.Message}");
            }
            finally
            {
                Con.CloseConn();
            }
        }

        //Select
        public eUsers ViewUser(int Id)
        {
            eUsers users= null;

            try
            {
                using (SqlCommand cmd = new SqlCommand("spSelectUserById", Con.OpenConn()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Id", Id));

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            users = new eUsers
                            {
                                Id1 = Convert.ToInt32(reader["Id"]),
                                Username1 = reader["Username"].ToString(),
                                Password1 = reader["Password"].ToString(),
                                FirstName1 = reader["FirstName"].ToString(),
                                LastName1 = reader["LastName"].ToString(),
                                Email1 = reader["Email"].ToString(),
                                PhoneNumber1 = reader["Phone"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener información del usuario: {ex.Message}");
            }
            finally
            {
                Con.CloseConn();
            }

            return users;
        }

        //Delete
        public void DeleteUser(eUsers users)
        {
            cmd = new SqlCommand("spDeleteUser", Con.OpenConn());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@Id", users.Id1));
            cmd.ExecuteNonQuery();
            Con.CloseConn();
        }

        /*public void ViewUsers(eUsers users)
        {
            throw new NotImplementedException();
        }*/

    }
}
