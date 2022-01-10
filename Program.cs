using System;
using online_application.menu;
using online_application.Cake;


namespace online_application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to cake shopping");
            HomePage homepage = new HomePage();
            
            HomePage.RegisterOrLogin();
           

            
        }
    }
}
