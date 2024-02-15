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

            Console.Write("Enter client age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter client tel. number: ");
            string telNumber = Console.ReadLine();

            clients.Add(new Client { Name = name, Surname = surname, Age = age, TelNumber = telNumber });
            Console.WriteLine("Client added successfully.");
        }

        public void FindClient()
        {
            Console.WriteLine("1. Find by name");
            Console.WriteLine("2. Find by surname");
            Console.WriteLine("3. Find by age");
            Console.WriteLine("4. Find by tel. number");

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
                    Console.Write("Enter client age: ");
                    int age = int.Parse(Console.ReadLine());
                    var byAge = clients.FindAll(c => c.Age == age);
                    PrintClients(byAge);
                    break;
                case 4:
                    Console.Write("Enter client Telephone Number: ");
                    string telNumber = Console.ReadLine();
                    var byTelNumber = clients.FindAll(c => c.TelNumber.Equals(telNumber, StringComparison.OrdinalIgnoreCase));
                    PrintClients(byTelNumber);
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
                Console.WriteLine("\nName: {0}  Surname: {1} \nAge: {2}  Tel.Number: {3}", client.Name, client.Surname, client.Age, client.TelNumber);
            }
        }
    }
}
