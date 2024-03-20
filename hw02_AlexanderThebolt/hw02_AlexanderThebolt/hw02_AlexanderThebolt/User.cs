using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw02_AlexanderThebolt
{
    class User
    {
        //Members
        private string username;
        private string fName;
        private string lName;
        private string email;
        private string password;

        //Constructors
        public User()
        {

        }

        public User(string u, string f, string l, string e, string p)
        {
            username = u;
            fName = f;
            lName = l;
            email = e;
            password = p;
        }

        //Functions
        public string getUsername()
        {
            return username;
        }

        public void setUsername(string u)
        {
            username = u;
        }

        public string getFName()
        {
            return fName;
        }

        public void setFName(string f)
        {
            fName = f;
        }

        public string getLName()
        {
            return lName;
        }

        public void setLName(string l)
        {
            lName = l;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string e)
        {
            email = e;
        }

        public string getPassword()
        {
            return password;
        }

        public void setPassword(string p)
        {
            password = p;
        }
    }
}
