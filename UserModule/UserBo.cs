using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using online_application.menu;
using online_application.UserException;
using online_application.UserModule;



namespace online_application.UserModule
{


    class UserBo
    {

        string[] userArray;
        UserDataValidation datavalidation = new UserDataValidation();

        public void LoginUser(string useremail, string userpassword, List<User> userList)
        {
            try
            {

                if (userList.Count > 0 && userList != null)
                {
                    foreach (User user in userList)
                    {
                        if (!(user.Usermail.Equals(useremail) && user.Userpass.Equals(userpassword)))
                        {
                            Console.Write("Invalid User Details");
                            Console.Write("Enter valid User Details or Create New Account");
                            HomePage.RegisterOrLogin();
                        }
                        else
                        {
                            Console.WriteLine("Login Successfull...");

                        }
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                HomePage.RegisterOrLogin();
            }
        }
        public string CheckExistingUser(string useremail, List<User> userList)
        {
            try
            {

                foreach (User user in userList)
                {
                    if (user.Usermail.Equals(useremail))
                    {
                        Console.WriteLine("This Email Address Exist \nRegister Valid Details");
                        HomePage.RegisterOrLogin();
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                HomePage.RegisterOrLogin();
            }

            return useremail;
        }

        /*public void CreateUser(usermail,List<User> userList)
        {
            

           userList.Add(new User(username, CheckExistingUser(useremail, userList), userpassword,usertype));
           Console.WriteLine("Your User Account Has Been Created Successfully!...");
           Console.WriteLine();
           HomePage.RegisterOrLogin();

        }*/
    }
}
     /*  public void CreateUser(string userDetails, List<User> userList)
        {
            try
            {
                userArray = userDetails.Split(",");
                userArray = ArrayNumberOfValueException.checkSizeOfArray(userArray);
               Validation.validateEmail(userArray[1]);
               Validation.validatePassword(userArray[2]);
                userList.Add(new User(userArray[0], CheckExistingUser(userArray[1], userList), userArray[2], userArray[3]));
                Console.WriteLine("Your User Account Has Been Created Successfully!...");
                Console.WriteLine();
                HomePage.RegisterOrLogin();

            }
            catch (ArrayNumberOfValueException e)
            {
                Console.WriteLine("ArrayNumberOfValueException: {0}", e.Message);
                Console.WriteLine();
                Console.WriteLine("Enter User Input Properly");
                HomePage.RegisterOrLogin();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();
                Console.WriteLine("Enter User Input Properly");
                HomePage.RegisterOrLogin();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Enter User Input Properly");
                HomePage.RegisterOrLogin();
            }
        }

        
   }
}*/
