using System;
using System.Collections.Generic;
using System.Text;
using DatabaseStuff19.DAO;

namespace DatabaseStuff19
{
    class ShoeStoreCLI
    {
        private readonly IShoeDao shoeDao;

        public ShoeStoreCLI(IShoeDao shoeDao)
        {
            this.shoeDao = shoeDao;
        }

        public void DisplayTop()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Welcome to the Shoe Store Database!");
            Console.WriteLine("----------------------------------");
        }

        public void DisplayMenu()
        {
            //so here, let's focus on asking what they want
            // they might wanna see the whole inventory

            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1) Display All Shoes");
            Console.WriteLine("2) Search for a Shoe by ID");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                foreach (string thing in shoeDao.GetInventory())
                {
                    Console.WriteLine(thing);
                }
                Console.ReadLine();
            }
            if (choice == 2)
            {
                GetShoeById();
            }

        }

        public void GetShoeById()
        {
            Console.WriteLine("What shoe are you looking for? Toss in an ID.");
            int idChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You chose: {shoeDao.GetShoe(idChoice).ShoeName}");
        }
    }
}
