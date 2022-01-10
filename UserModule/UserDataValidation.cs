using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Text.RegularExpressions;


namespace online_application.UserModule
{
    class UserDataValidation 
    {

        string userpassword, useremail;
        public string validatePassword(string userpassword)
        {
            if (Regex.IsMatch(userpassword, @"^[a-zA-Z_ ]*$"))
                return userpassword;
            else
            {
                Console.WriteLine("Please Enter a valid password. ");
                userpassword = Console.ReadLine();
                validatePassword(userpassword);
            }
            return userpassword;
        }



        public string  validateEmail(string useremail)
        {
            if (Regex.IsMatch(useremail, @"(^[a-zA-Z]*\.[a-zA-Z]*)+@[A-Za-z]*\.[a-zA-Z]*$"))
                return useremail;
            else
            {
                Console.WriteLine("Please Enter a valid email id. ");
                useremail = Console.ReadLine();
                validateEmail(useremail);
            }
            return useremail;
        }
        /* public void validateEmail(string email)

         {z
             Regex regex = new Regex("/^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^\\s]).{8,}$/");
             if (regex.IsMatch(email))
             {
                 Console.WriteLine(email);
             }
             else
             {
                 Console.WriteLine("enter valid email");
                 this.email = Console.ReadLine();
             }

         }*/
    }
}
        /* public string validateEmail(string email)
        {
            Regex regex = new Regex("^[a-z0-9!#$]@[a-z].[com]$");
          if (!regex.IsMatch(email))
             {
                 Console.WriteLine("Invalid Email Address");
                 Console.WriteLine("Enter valid mail address:");
                 this.email = Console.ReadLine();
                 validateEmail(this.email);
             }
             return this.email;
         }*/

       
