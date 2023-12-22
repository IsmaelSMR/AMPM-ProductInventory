using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entity;


namespace Domain
{
    public class doUsers
    {
        dUsers ObjUsers = new dUsers();

        //Create
        public void CreateUser(eUsers users)
        {
            ObjUsers.CreateUser(users);
        }

        //Update
        public void EditUser(eUsers users)
        {
            ObjUsers.EditUser(users);
        }

        //Read
        public void ViewUser(int userId)
        {
            eUsers user = ObjUsers.ViewUser(userId);
            // Resto de tu lógica aquí...
        }

        //Delete
        public void DeleteUser(eUsers users)
        {
            ObjUsers.DeleteUser(users);
        }

    }
}
