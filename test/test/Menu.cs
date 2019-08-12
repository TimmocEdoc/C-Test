using System;

namespace test
{
    public class Menu
    {
        public static void Main(string[] args)
        {
            Store s = new Store();
            int choose;
            string id;
            string name;
            int price;
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1| Add product records.");
                Console.WriteLine("2| Display product records.");
                Console.WriteLine("3| Delete product by Id.");
                Console.WriteLine("4| Exit.");
                choose = Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Enter Product ID:");
                        id = Console.ReadLine();
                        Console.WriteLine("Enter Name:");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter Price:");
                        price = Convert.ToInt32(Console.ReadLine());
                        s.AddProduct(id, name, price);
                        break;
                    case 2:
                        s.DisplayProduct();
                        break;
                    case 3:
                        Console.WriteLine("Enter Product ID:");
                        id = Console.ReadLine();
                        s.DeleteProduct(id);
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Error.");
                        break;
                }   
            }
        }
    }
}