using System;
using System.Collections.Generic;
using System.Text;
using online_application.UserModule;
using online_application.UserException;
using online_application.Cake;

namespace online_application.menu

{
    class HomePage
    {
        public static string choiceReader;
        public static int choice;
        static string useremail, userpassword,username,mail,passcode;
        static string userDetails;
        public string cakename, flavour, kilogram, price;
        static List<User> userList = new List<User>();
        UserDataValidation dataValidation= new UserDataValidation();
       

        public static void RegisterOrLogin()
        {
            UserBo userBO = new UserBo();
            UserDataValidation dataValidation = new UserDataValidation();
            Product product = new Product();

            Console.WriteLine();

            Console.WriteLine("------MENU------------");
            
            Console.WriteLine("Press  1->Login   2->Register  3->admin  4->Exit");
            try
            {
                choiceReader = Console.ReadLine();
                choice = InputNotstringCharException.check(choiceReader);

                switch (choice)
                {
                    case 1:
                       
                        Console.WriteLine("--------------SIGN IN ACCOUNT ---------------------");
                        
                        Console.WriteLine();
                        Console.WriteLine("Enter your email:");
                        useremail = Console.ReadLine();
                        dataValidation.validateEmail(useremail);

                        Console.WriteLine("Enter your password:");
                        userpassword = Console.ReadLine();
                        dataValidation.validatePassword(userpassword);
                        Console.WriteLine("Login sucessfully");
                        

                        product.Cookie();
                        userBO.LoginUser(useremail, userpassword, userList);
                        

                   

                        break;
                    case 2:
                        
                        Console.WriteLine("--------Register User Account-----------");
                        Console.WriteLine("Enter name:");
                        username = Console.ReadLine();
                        
                        Console.WriteLine("Enter email:");
                        useremail = Console.ReadLine();
                        dataValidation.validateEmail(useremail);
                        Console.WriteLine("Enter password:");
                        userpassword = Console.ReadLine();
                        dataValidation.validatePassword(userpassword);
                        //userList.Add(new User(username,CheckExistingUser(useremail, userList), userpassword,usertype));
                         //userBO.CreateUser( useremail,userList);
                        Console.WriteLine("Your User Account Has Been Created Successfully!...");
                        Console.WriteLine("------U can login now-----");
                        RegisterOrLogin();


                        /*Console.WriteLine("Input Format => Name,Email,Password,User_Type(User)");
                        Console.WriteLine("Enter User Details:");
                        userDetails = Console.ReadLine();
                        userBO.CreateUser(userDetails, userList);
*/
                        break;
                 case 3:
                        
                            Admin admin = new Admin();
                            Console.WriteLine("--------Welcome to admin page--------");
                            Console.WriteLine("Enter your Admin mailID");
                            mail = Console.ReadLine();
                        Console.WriteLine("Enter your Admin passcode");

                        passcode = Console.ReadLine();
                            admin.Adminmenu(mail, passcode);
                        Console.WriteLine("Are you want to see cakelist press 1->   add iteam 2->  delete iteam ->3");
                       // Console.WriteLine("Press  1-> yes 2->No");

                        try
                        {
                            choiceReader = Console.ReadLine();
                            choice = InputNotstringCharException.check(choiceReader);

                            switch (choice)
                            {
                                case 1:
                                   
                                    Console.WriteLine("this the cake list");
                                    product.Cookie();

                                    break;

                                case 2:
                                    

                                    Console.WriteLine("Are you want to add iteams press->1");
                                    product.Addproduct();
                                   
                                    break;
                                case 3:
                                    //Console.WriteLine("Are you want to delete iteams press->2");
                                    

                                    product.delproduct();

                                    break;

                            }
                            
                        }
                        
                        catch (InputNotstringCharException e)
                        {
                            Console.WriteLine("InputNotStringCharException: {0}", e.Message);
                            RegisterOrLogin();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            RegisterOrLogin();
                        }
                        break;
                    case 4:
                        Console.WriteLine("Thank You");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter correct choice");
                        RegisterOrLogin();
                        break;
                }
            }
            catch (InputNotstringCharException e)
            {
                Console.WriteLine("InputNotStringCharException: {0}", e.Message);
                RegisterOrLogin();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                RegisterOrLogin();
            }
        }

        

    }
}

