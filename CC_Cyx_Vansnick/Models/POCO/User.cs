using CC_Cyx_Vansnick.DAL.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC_Cyx_Vansnick.Models.POCO
{
    public abstract class User
    {
       
        private string password;
        private string firstName;
        private string lastName;
        private string email;
        private string phoneNumber;
        private string address;
        private int idUser;
        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }


        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }


        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public User()
        {

        }
        public User(string pw, string fn, string ln,  string e, string ph, string a)
        {
            password = pw;
            firstName = fn;
            lastName = ln;
            email = e;
            phoneNumber = ph;
            address = a;
        }
        public User FindUser(IUsersDAL _usersDAL, string email, string password)
        {
            return _usersDAL.FindUser(email, password);
        }

        public User FindUserById(IUsersDAL _usersDAL, int id)
        {
            return _usersDAL.FindUserById(id);
        }
    }
}
