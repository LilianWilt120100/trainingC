using System;
using System.Linq.Expressions;
using trainingC;
using static trainingC.Personnages;
    internal class Program
    {

        static void Main(string[] args)
        {
           

            string t ="";
            Console.WriteLine("Quel est ton pseudo ?");
            Personnages p = new Personnages(Console.ReadLine());

            Console.WriteLine("Quel est ton adversaire ?");
            Personnages adv = new Personnages(Console.ReadLine());

            Console.WriteLine("Quel est ton type préféré ?");
           
         

            Console.WriteLine("Bienvenue à toi " + p.pseudo);
            Console.WriteLine("Tu as "+ p.pv+" points de vie");
            Console.WriteLine("Voici tes attaques ");
            for(int i=0 ; i<p.attaques.Length ; i++){
                Console.WriteLine(p.attaques[i] +"\r\n");

            }

            Console.WriteLine("Tu vas affronter " + adv.pseudo);
            adv.prendreDegats(2);
            Console.WriteLine("L'adversersaire a maintenant "+adv.pv+" points de vie");
            //Console.WriteLine(p.type);



        }
    }
