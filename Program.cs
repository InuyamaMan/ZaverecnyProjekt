using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Functions functions = new Functions();

            while (true)
            {
                Console.WriteLine("1. Add new client");
                Console.WriteLine("2. Find client");
                Console.WriteLine("3. Delete client");
                Console.WriteLine("4. Show all clients");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        functions.AddNewClient();
                        break;
                    case 2:
                        functions.FindClient();
                        break;
                    case 3:
                        functions.DeleteClient();
                        break;
                    case 4:
                        functions.ShowAllClients();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
