using DAB_Assignment_2.Models;
using DAB_Assignment_2.DAL;
using System;
using DAB_Assignment_2.Data;

namespace DAB_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppDbContext())
            {
                while (true)
                {
                    Console.Clear();

                    DbInitializer init = new DbInitializer();
                    init.Initialize(db);
                    Views view = new Views();
                    InsertData data = new InsertData();
                    
                    //System.Console.WriteLine("Det gik godt"); 

                    Console.Write("\t\t Velkommen til WhereToEat\n");

                    Console.Write("Indtast et tal mellem 1 og 4 for at vælge den valgte metode\n");
                    Console.WriteLine("1: Liste af restauranter ud fra type");
                    Console.WriteLine("2: Menu for en given restaurante");
                    Console.WriteLine("3: Reviews for en given restaurante");
                    Console.WriteLine("4: Indsæt data");

                    string valg = Console.ReadLine();

                    if (valg == "1")
                    {
                        Console.Write("Du har valgt Metode A");
                        Console.Write("Vælg ud fra typen af Restaurant");
                        Console.WriteLine("De mulige Typer er:");
                        Console.Write("\t 1: Dessert \n");
                        Console.Write("\t 2: Dinner \n");
                        Console.Write("\t 3: Breakfast \n");
                        Console.Write("\t 4: Lunch \n");

                        string valg1 = Console.ReadLine();

                        if (valg1 == "1")
                        {
                            view.MethodA("Dessert", db);
                        }

                        if (valg1 == "2")
                        {
                            view.MethodA("Dinner", db);
                        }

                        if (valg1 == "3")
                        {
                            view.MethodA("Breakfast", db);
                        }

                        if (valg1 == "4")
                        {
                            view.MethodA("Lunch", db);
                        }
                    }

                    if (valg == "2")
                    {
                        Console.WriteLine("Du har valgt Metode B");
                        Console.WriteLine("Vælg ud fra adressen af Restaurant");
                        Console.WriteLine("De mulige adresser er:");
                        int counter = 1;

                        foreach (var adresse in db.Restaurants)
                        {

                            Console.Write("\t {0}: {1} - {2} \n", counter, adresse.Address, adresse.Name);
                            counter++;
                        }

                        Console.WriteLine("Indtast et tal mellem 1 og 8");

                        string valg2 = Console.ReadLine();

                        switch (valg2)
                        {
                            case "1":
                                view.MethodB("Mordor Lane 35", db);
                                break;
                            case "2":
                                view.MethodB("Fast Food Road 88", db);
                                break;
                            case "3":
                                view.MethodB("Candy Way 15", db);
                                break;
                            case "4":
                                view.MethodB("Growl Hill 32", db);
                                break;
                            case "5":
                                view.MethodB("Fancy Boulevard", db);
                                break;
                            case "6":
                                view.MethodB("Early Bird 75", db);
                                break;
                            case "7":
                                view.MethodB("Strange Green 2", db);
                                break;
                            case "8":
                                view.MethodB("Sleepy Road 14", db);
                                break;
                            default:
                                Console.Write("Prøv igen, Indtast et tal mellem 1 og 8");
                                break;
                        }


                    }

                    if (valg == "3")
                    {
                        Console.WriteLine("Du har valgt Metode C");
                        Console.WriteLine("Vælg ud fra adressen af Restaurant");
                        Console.WriteLine("De mulige adresser er:");
                        int counter = 1;


                        foreach (var adresse in db.Restaurants)
                        {

                            Console.Write("\t {0}: {1} - {2} \n", counter, adresse.Address, adresse.Name);
                            counter++;
                        }

                        Console.WriteLine("Indtast et tal mellem 1 og 8\n");

                        string valg2 = Console.ReadLine();

                        switch (valg2)
                        {
                            case "1":
                                view.MethodC("Mordor Lane 35", db);
                                break;
                            case "2":
                                view.MethodC("Fast Food Road 88", db);
                                break;
                            case "3":
                                view.MethodC("Candy Way 15", db);
                                break;
                            case "4":
                                view.MethodC("Growl Hill 32", db);
                                break;
                            case "5":
                                view.MethodC("Fancy Boulevard", db);
                                break;
                            case "6":
                                view.MethodC("Early Bird 75", db);
                                break;
                            case "7":
                                view.MethodC("Strange Green 2", db);
                                break;
                            case "8":
                                view.MethodC("Sleepy Road 14", db);
                                break;
                            default:
                                Console.Write("Prøv igen, Indtast et tal mellem 1 og 8");
                                break;
                        }
                    }
                    if (valg == "4")
                    {
                        Console.WriteLine("Du har valgt Indsæt data");
                        Console.WriteLine("De mulige valg er:");
                        Console.WriteLine("1: Indsæt ny restaurante");
                        Console.WriteLine("2: Indsæt nyt review");
                        Console.WriteLine("Indtast et tal mellem 1 og 2\n");

                        string valg2 = Console.ReadLine();

                        switch (valg2)
                        {
                            case "1":
                                data.InsertRestaurant(db);
                                break;
                            case "2":
                                data.InsertReview(db);
                                break;
                            default:
                                Console.Write("Prøv igen, Indtast et tal mellem 1 og 2");
                                break;
                        }
                    }
                    Console.WriteLine("Press enter to start over or X to exit the program");
                    string input = Console.ReadLine();
                    if (input == "X" || input == "x") break;
                }
            }
        }
    }
}