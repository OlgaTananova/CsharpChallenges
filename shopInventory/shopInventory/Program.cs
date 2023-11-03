using System;

namespace shopInventory
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Add your inventory items:");

            Shop shop = new Shop();
            for (int index = 0; index < 3; index++)
            {
                var item = Console.ReadLine();
                AddItem(index, item, shop);
            }

            // MARK: Result
            Console.WriteLine("Retrieve all stored items:");
            GetAllItems(shop);
        }

        // MARK: Write your solution here
        public static void AddItem(int index, string name, Shop shop)
        {
            try
            {
                shop[index] = name;
                
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        // MARK: Write your solution here
        public static void GetAllItems(Shop shop)
        {
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    Console.WriteLine(shop[i]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}