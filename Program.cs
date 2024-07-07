using System;
using trainingC;
using static trainingC.Personnages;
    internal class Program
    {

        static void Main(string[] args)
        {
           


            Console.WriteLine("Quel est ton pseudo ?");
            Personnages p = new Personnages(Console.ReadLine());
            Console.WriteLine("Bienvenue à toi " + p.pseudo);
            Console.WriteLine("Tu as "+ p.pv+" points de vie");
            Console.WriteLine("Voici tes attaques ");
            for(int i=0 ; i<=p.attaques.Length ; i++){
                Console.WriteLine(p.attaques[i] +"\r\n");

            }


        }
    }
