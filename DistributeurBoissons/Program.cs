using DistributeurBoissons.Builder;
using DistributeurBoissons.Modeles;
using System;

namespace DistributeurBoissons
{
    class Program
    {
        static void Main(string[] args)
        {
            string exit;
            do
            {
                Console.Clear();
                Console.WriteLine("----------------------DISTRIBUTEUR AUTOMATIQUE DE BOISSONS----------------------");
                Console.Write("\n\n");
                Console.WriteLine("Veuillez sélectionner une boisson.");
                Console.WriteLine("1- Expresso");
                Console.WriteLine("2- Allongé");
                Console.WriteLine("3- Capuccino");
                Console.WriteLine("4- Chocolat");
                Console.WriteLine("5- The");
                Console.Write("\n");
                Console.WriteLine("--------------------------------");

                string choixClient = Console.ReadLine();
                SelectionnerBoisson(choixClient);
                Console.Write("\n\n");
                Console.WriteLine("-------Voulez vous continuer? 1- Pour oui; 0 | Pour non-------");
                exit = Console.ReadLine();
            } while (exit == "1");
        }

        private static void SelectionnerBoisson(string choixClient)
        {
            Boisson boisson;
            Distributeur distributeur = new Distributeur();

            switch (choixClient)
            {
                case "1":
                    ExpressoBuilder expresso = new ExpressoBuilder();
                    boisson = distributeur.FabriquerBoisson(expresso);
                    Console.WriteLine(boisson.AfficherBoisson());
                    break;

                case "2":
                    AllongeBuilder allonge = new AllongeBuilder();
                    boisson = distributeur.FabriquerBoisson(allonge);
                    Console.WriteLine(boisson.AfficherBoisson());
                    break;

                case "3":
                    CapuccinoBuilder capuccino = new CapuccinoBuilder();
                    boisson = distributeur.FabriquerBoisson(capuccino);
                    Console.WriteLine(boisson.AfficherBoisson());
                    break;

                case "4":
                    ChocolatBuilder chocolat = new ChocolatBuilder();
                    boisson = distributeur.FabriquerBoisson(chocolat);
                    Console.WriteLine(boisson.AfficherBoisson());
                    break;

                case "5":
                    TheBuilder the = new TheBuilder();
                    boisson = distributeur.FabriquerBoisson(the);
                    Console.WriteLine(boisson.AfficherBoisson());
                    break;
            }

        }
    }
}
