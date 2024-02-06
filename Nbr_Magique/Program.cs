using System;

namespace Nbr_Magique
{
    internal class Program
    {


        static int DemanderNbr(int min, int max) 
        {
            
            int num = 0;
            // peut échouer c'est pour cela que l'on fait un try

            while ((num < min) || (num > max))
            {
                Console.Write($"Choisissez un nombre entre {min} et {max}:");
                string reponse = Console.ReadLine();
                try
                {
                    num = int.Parse(reponse);

                    if ((num < min) || (num > max))
                    {
                        Console.WriteLine($"ERREUR : le nombre doit être entre {min} et {max}!");
                    
                    }
                     
                }
                catch 
                {
                    Console.WriteLine("ERREUR : Entrez un nombre valide");
                }
            }
           

            
            return num;
            
        }

       
        static void Main(string[] args)
        {

            Random rand = new Random(); 

            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;
            int NOMBRE_MAGIQUE = rand.Next(NOMBRE_MIN, NOMBRE_MAX+1);
            int nombre = NOMBRE_MAGIQUE + 1;

            int nbVie = 4;

            //while (nbVie > 0)
            for (; nbVie > 0 ; nbVie--)
            {
                Console.WriteLine();
                Console.WriteLine("Vie restante : " + nbVie);
                nombre = DemanderNbr(NOMBRE_MIN, NOMBRE_MAX);

                if (nombre < NOMBRE_MAGIQUE)
                {
                    Console.WriteLine("Le nombre magique est plus grand");
                    
                }
                else if (nombre > NOMBRE_MAGIQUE)
                {
                    Console.WriteLine("Le nombre magique est plus petit");
           
                }
                else
                {
                    Console.WriteLine("Bravo ! Vous avez trouvé le nombre magique !");
                    break;
                }
                //nbVie--;

            }

            if (nbVie == 0)
            {
                Console.WriteLine("GAME OVER!  Le nombre magique était : " + NOMBRE_MAGIQUE);
            }
           
           
           

            
        }
    }
}