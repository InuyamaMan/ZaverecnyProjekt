using ZaverecnyProjekt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjekt
{
    class Functions
    {   //Seznam klientů, do kterého se budou ukládat informace po přidání
        static List<Client> clients = new List<Client>();

        //Metoda pro pčidání nového klienta
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
            
            //Vytvoření nové instance klienta a přidání do seznamu
            clients.Add(new Client { Name = name, Surname = surname, Age = age, TelNumber = telNumber });
            Console.WriteLine("Client added successfully.");
        }

        //Metoda pro nalezení již uloženého klienta
        public void FindClient()
        {
            Console.WriteLine("1. Find by name");       //Hledání podle jména
            Console.WriteLine("2. Find by surname");    //Hledání podle příjmení
            Console.WriteLine("3. Find by age");        //Hledání podle věku
            Console.WriteLine("4. Find by tel. number");//Hledání podle telefonního čísla

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter client name: ");   //Hledání podle jména
                    string name = Console.ReadLine();
                    var byName = clients.FindAll(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                    PrintClients(byName);
                    break;
                case 2:
                    Console.Write("Enter client surname: ");//Hledání podle příjmení
                    string surname = Console.ReadLine();
                    var bySurname = clients.FindAll(c => c.Surname.Equals(surname, StringComparison.OrdinalIgnoreCase));
                    PrintClients(bySurname);
                    break;
                case 3:
                    Console.Write("Enter client age: ");    //Hledání podle věku
                    int age = int.Parse(Console.ReadLine());
                    var byAge = clients.FindAll(c => c.Age == age);
                    PrintClients(byAge);
                    break;
                case 4:
                    Console.Write("Enter client Telephone Number: ");//Hledání podle telefonního čísla
                    string telNumber = Console.ReadLine();
                    var byTelNumber = clients.FindAll(c => c.TelNumber.Equals(telNumber, StringComparison.OrdinalIgnoreCase));
                    PrintClients(byTelNumber);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }

        //Metoda pro smazání klienta ze seznamu po zadání jména, příjmení a věku
        public void DeleteClient()
        {
            Console.Write("Enter client name to delete: ");
            string name = Console.ReadLine();

            Console.Write("Enter clĺient surname to delete: ");
            string surname = Console.ReadLine();

            Console.Write("Enter client age to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Invalid age input. Deletion canceled.");
                return;
            }

            Client clientToRemove = clients.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase) && c.Surname.Equals(surname, StringComparison.OrdinalIgnoreCase) && c.Age == age);

            if (clientToRemove != null)
            {
                clients.Remove(clientToRemove);
                Console.WriteLine("Client deleted successfully.");
            }
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
