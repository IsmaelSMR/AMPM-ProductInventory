using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eUsers
    {
        private int Id;
        private string Username;
        private string Password;
        private string FirstName;
        private string LastName;
        private string Email;
        private string PhoneNumber;

        public int Id1 { get => Id; set => Id = value; }
        public string Username1 { get => Username; set => Username = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }
    }
}
