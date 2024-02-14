using ZaverecnyProjekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt
{
    class Functions
    {
        static List<Client> clients = new List<Client>();
        public void AddNewClient()
        {
            Console.Write("Enter client name: ");
            string name = Console.ReadLine();

            Console.Write("Enter client surname: ");
            string surname = Console.ReadLine();

            Console.Write("Enter client birth date (yyyy-MM-dd): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            clients.Add(new Client { Name = name, Surname = surname, BirthDate = birthDate });
            Console.WriteLine("Client added successfully.");
        }

        public void FindClient()
        {
            Console.WriteLine("1. Find by name");
            Console.WriteLine("2. Find by surname");
            Console.WriteLine("3. Find by birth date");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter client name: ");
                    string name = Console.ReadLine();
                    var byName = clients.FindAll(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                    PrintClients(byName);
                    break;
                case 2:
                    Console.Write("Enter client surname: ");
                    string surname = Console.ReadLine();
                    var bySurname = clients.FindAll(c => c.Surname.Equals(surname, StringComparison.OrdinalIgnoreCase));
                    PrintClients(bySurname);
                    break;
                case 3:
                    Console.Write("Enter client birth date (yyyy-MM-dd): ");
                    DateTime birthDate = DateTime.Parse(Console.ReadLine());
                    var byBirthDate = clients.FindAll(c => c.BirthDate.Date == birthDate.Date);
                    PrintClients(byBirthDate);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        public void DeleteClient()
        {
            Console.Write("Enter client name to delete: ");
            string name = Console.ReadLine();

            int removed = clients.RemoveAll(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (removed > 0)
                Console.WriteLine("Client(s) deleted successfully.");
            else
                Console.WriteLine("Client not found.");
        }

        public void ShowAllClients()
        {
            if (clients.Count == 0)
            {
                Console.WriteLine("No clients found.");
            }
            else
            {
                Console.WriteLine("All clients:");
                PrintClients(clients);
            }
        }

        public void PrintClients(List<Client> clientList)
        {
            foreach (var client in clientList)
            {
                Console.WriteLine("Name: {0}, Surname: {1}, Birth Date: {2}", client.Name, client.Surname, client.BirthDate.ToString("yyyy-MM-dd"));
            }
        }
    }
}
