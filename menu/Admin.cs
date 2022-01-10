using System;
using System.Collections.Generic;

using System.Text;
using online_application.Cake;

namespace online_application.menu
{
    class Admin
    {
        private string mail,passcode;
        Product product = new Product();

        public void Adminmenu( string mail, string passcode)
        {
            if (mail == "priya@gmail.com" && passcode == "1234")
                Console.WriteLine("Adminlogin sucessfull");
            else
            {
                Console.WriteLine("enter valid MailID ");
                mail = Console.ReadLine();
                Console.WriteLine("enter valid passcode ");


                passcode = Console.ReadLine();

                Adminmenu(mail,passcode );
            }
        }

        /*public void Adminadd()
        {
            List<Cakes> CakeList = new List<Cakes>();
            Console.WriteLine("enter the cakename");
            String cakename=Console.ReadLine();
            Console.WriteLine("enter the flavour");

            String flavour = Console.ReadLine();
            Console.WriteLine("enter the kilogram");

            int kilogram = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the price");

            int price = Convert.ToInt32(Console.ReadLine());

            CakeList.Add(new Cakes(cakename,flavour,kilogram,price));
            product.Cookie();
            CakeList.ForEach(Console.WriteLine);*/

        }
    }

