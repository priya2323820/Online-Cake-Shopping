﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
   
using online_application.UserException;

namespace online_application.Cake
{
    class Product
    {
        List<Cakes> CakeList = new List<Cakes>();
        List<Cakes> OutputListofproduct = new List<Cakes>();
        Cakes c = new Cakes();


        public static string choiceReader;
        public static int choice;


        public void Cookie()
        {

            
            Console.WriteLine("-----this is the CakeList we have-----");

            CakeList.Add(new Cakes() { id = 1, cakename = "redvelvet", flavour = "staberry", kilogram = 1, price = 234 });
            CakeList.Add(new Cakes() { id = 2, cakename = "heart melting", flavour = "blueberry", kilogram = 1, price = 450 });

            CakeList.Add(new Cakes(3, "vennila", "vennila", 1, 350));
            CakeList.Add(new Cakes(4, "whiteforest", "vennila", 1, 3050));

            CakeList.Add(new Cakes(5, "redvelevt", "blackcurrent", 1, 450));
            CakeList.Add(new Cakes(6, "choclate cake", "choclate", 1, 1600));
            CakeList.Add(new Cakes(7, "black forest", "coffiee", 3, 1350));

            CakeList.Add(new Cakes(8, "Honeycake", "little pineapple", 1, 650));
            CakeList.ForEach(Console.WriteLine);
            /*CakeList.ForEach(delegate(Cakes name)
                  {
                  Console.WriteLine(name);

              });*/
            Console.WriteLine("Enter a choice:\n1.By Cakename 2.By price");
            int choice = Convert.ToInt32(Console.ReadLine());
            CakesBo cakesBO = new CakesBo();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the cakename");
                    string cakeName = Console.ReadLine();
                    OutputListofproduct = cakesBO.findCakes(CakeList, cakeName);
                    OutputListofproduct.ForEach(Console.WriteLine);
                    
                    break;

                case 2:

                    Console.WriteLine("Enter the price");
                    int price = Convert.ToInt32(Console.ReadLine());
                    OutputListofproduct = cakesBO.findCakesprice(CakeList, price);
                    OutputListofproduct.ForEach(Console.WriteLine);
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

            public void Addproduct()
            {

                Console.WriteLine("Enter the id:");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Cakename:");

                String cakename = Console.ReadLine();
                Console.WriteLine("Enter the flavour:");


                string flavour = Console.ReadLine();


                Console.WriteLine("Enter the Kilogram:");

                int kilogram = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the price:");

                int price = Convert.ToInt32(Console.ReadLine());


                CakeList.Add(new Cakes(id, cakename, flavour, kilogram, price));
                foreach (var cake in CakeList)
                {
                    Console.WriteLine(cake);

                }
                Console.WriteLine("Added sucessfully");

                Console.WriteLine("Do you want add again press1-> Exit press2-> del press3->");


                try
                {
                    choiceReader = Console.ReadLine();
                    choice = InputNotstringCharException.check(choiceReader);

                    switch (choice)
                    {
                        case 1:
                            Addproduct();
                            break;

                        case 2:
                            Console.WriteLine("Thank You");
                            Environment.Exit(0);
                            break;
                        case3:
                            delproduct();
                            break;


                    }

                }

                catch (InputNotstringCharException e)
                {
                    Console.WriteLine("InputNotStringCharException: {0}", e.Message);
                    Addproduct();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Addproduct();
                }


            }
        public void delproduct()
        {
            print();
            Console.WriteLine("Enter the Product id to remove iteam ");
           
            int del = Convert.ToInt32(Console.ReadLine());
            var itemtoremove = CakeList.Single(r => r.Id == del);
            if (itemtoremove != null)
                CakeList.Remove(itemtoremove);
            Console.WriteLine($"{itemtoremove.Id}{itemtoremove.cakename}{itemtoremove.flavour}{itemtoremove.kilogram}{itemtoremove.price}");
            Console.WriteLine("------sucessfully removed-----");
            var balanceiteam = from x in CakeList select x;
            foreach (var iteam in balanceiteam)
            {

                Console.WriteLine($"{iteam.Id}\t{iteam.cakename}\t{iteam.flavour}\t{iteam.kilogram}\t{ iteam.price}");
            }
        }
        public void print()
        {
            Console.WriteLine("-----this is the CakeList we have-----");

            CakeList.Add(new Cakes() { id = 1, cakename = "redvelvet", flavour = "staberry", kilogram = 1, price = 234 });
            CakeList.Add(new Cakes() { id = 2, cakename = "heart melting", flavour = "blueberry", kilogram = 1, price = 450 });

            CakeList.Add(new Cakes(3, "vennila", "vennila", 1, 350));
            CakeList.Add(new Cakes(4, "whiteforest", "vennila", 1, 3050));

            CakeList.Add(new Cakes(5, "redvelevt", "blackcurrent", 1, 450));
            CakeList.Add(new Cakes(6, "choclate cake", "choclate", 1, 1600));
            CakeList.Add(new Cakes(7, "black forest", "coffiee", 3, 1350));

            CakeList.Add(new Cakes(8, "Honeycake", "little pineapple", 1, 650));
            CakeList.ForEach(Console.WriteLine);
        }
    }


        
}
/*Console.WriteLine("Enter ProductID to remove");
int uno = Convert.ToInt32(Console.ReadLine());
var itemToRemove = list.Find(r => r.ProductId == uno);
if (itemToRemove != null)
    list.Remove(itemToRemove);
Console.WriteLine($"{itemToRemove.ProductId}{itemToRemove.Name}{itemToRemove.Brand}{itemToRemove.Price}{ itemToRemove.Quantity}");
Console.WriteLine("------------sucessfully Removed---------------");

var query2 = from x in list select x;
foreach (var item in query2)
{
    Console.WriteLine(item.ProductId+" "+item.Name+" "+item.Brand+" "+item.Price+" "+item.Quantity );
    Console.WriteLine($"{item.ProductId}{item.Name}{item.Brand}{item.Price}{ item.Quantity}");
}*/