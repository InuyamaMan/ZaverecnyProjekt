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
            //Vytvoření instance Functions
            Functions functions = new Functions();

            //Hlavní cyklus programu, který zajistí aby se výběr možností znovu vypsal dokud uživatel nezvolí "Exit"
            while (true)
            {   //Výběr možností pro správu klientů
                Console.WriteLine("\nCLIENT MANAGEMENT");
                Console.WriteLine("1. Add new client"); //Přidá klienta
                Console.WriteLine("2. Find client");    //Najde klienta
                Console.WriteLine("3. Delete client");  //Smaže klienta
                Console.WriteLine("4. Show all clients");//Vypíše všechny klienty
                Console.WriteLine("5. Exit");   //Ukončí program

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        functions.AddNewClient();   //Volání metody pro přidání nového klilenta
                        break;
                    case 2:
                        functions.FindClient();     //Volání metody pro nalezení klienta
                        break;
                    case 3:
                        functions.DeleteClient();   //Volání metody pro smazání klienta
                        break;
                    case 4:
                        functions.ShowAllClients(); //Volání metody pro výpis všech klientů
                        break;
                    case 5:
                        Environment.Exit(0);        //Volání ukončení programu
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again."); //Chybová hláška v případě zadání špatné volby
                        break;
                }
            }
        }
    }
}
