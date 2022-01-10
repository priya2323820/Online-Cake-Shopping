/*  Title:Online  Cake Shopping
    Author: Priyadharshini
    created at: 31/Dec/2021
Reviewed by: Akshaya 
updated at:04/Jan/2022
     */
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace online_application.UserModule
{
    class User
    {
        private string UserName,UserMail, UserPass, UserType;

        public User(string username, string usermail, string userpass, string usertype)
        {
            this.UserName = username;
            this.UserMail = usermail;
            this.UserPass = userpass;
            this.UserType = usertype;
        }

        public string Username { get => UserName; set => UserName = value; }
        public string Usermail { get => UserMail; set => UserMail = value; }
        public string Userpass { get => UserPass; set => UserPass = value; }
        public string Usertype { get => UserType; set => UserType = value; }

        public override string ToString()
        {
            return string.Format(this.UserName + " " + this.UserMail + " " + this.UserPass + " " + this.UserType);
        }
    }
}
