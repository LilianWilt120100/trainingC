using System.Dynamic;

namespace trainingC
{
       public class Personnages(string pseudo)
    {
            public string pseudo = pseudo;
            public string [] attaques = ["eau", "feu"];
            public int degats=2;
            public int pv=10;

            public string type = ""; 


        /**public string nom
        {
            get => pseudo;
        }*/
        public int prendreDegats(int degat) => pv -= degat;
        
        public string chgtType(string ntype) => type = ntype;
    }

    


    

}