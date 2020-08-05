using System;
using System.Collections.Generic;

namespace Test_Tabsters

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour Tabsters! bienvenus à Petshop\n");


            Magasin magasin = new Magasin();
            magasin.Trésorerie = 10000; // on démarre avec un budget de  10000€

            Console.WriteLine("La trésorerie dispose initialement de : " + magasin.Trésorerie + " euros\n");


            Chat Minou = new Chat(370, "persan");
            Chien Cook = new Chien(280, "caniche");
            Chat Nougat = new Chat(760, "siamois");


            Console.WriteLine("prix de minou le chat: " + Minou.prix);
            Console.WriteLine("prix de Cook le chien : " + Cook.prix);
            Console.WriteLine("prix de Nougat le chat: " + Nougat.prix);
            Console.WriteLine("\n\n");

            magasin.achatAnimal(Minou);
            magasin.achatAnimal(Nougat);
            magasin.achatAnimal(Cook);

            Console.WriteLine("Après premier achat de Minou et Nougat les chats et Cook le chien : ");
            Console.WriteLine("la trésorie dispose actuellemnt de : " + magasin.Trésorerie + " euros\n");

            List<Animal> cartoonDogs = new List<Animal>();
            Chien Akamaru = new Chien(300, "kiba");
            Chien Balto = new Chien(1520, "siberian huskey");
            Chien Bolt = new Chien(800, "White Shepherd");

            cartoonDogs.Add(Akamaru);
            cartoonDogs.Add(Balto);
            cartoonDogs.Add(Bolt);

            magasin.achatGroupe(cartoonDogs);


            Console.WriteLine("Après achat par groupe de "+cartoonDogs.Count+" chiens :");
            Console.WriteLine("la trésorie dispose actuellemnt de : " + magasin.Trésorerie + " euros\n");


            magasin.venteAnimal(Nougat);
            Console.WriteLine("Après la vente de Nougat le chat :");
            Console.WriteLine("la trésorie dispose actuellemnt de : " + magasin.Trésorerie + " euros\n");



            magasin.venteGroupe(cartoonDogs);
            Console.WriteLine("Après vente par groupe de " + cartoonDogs.Count + " chiens :");
            Console.WriteLine("la trésorie dispose actuellemnt de : " + magasin.Trésorerie + " euros\n");


            Console.WriteLine("Fin des tests. Merci !");


        }
    }
}
