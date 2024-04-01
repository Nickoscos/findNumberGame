//Jeu du Trouve le Nombre.
//L'utilisateur saisie un chiffre entre 1 et 100. Un ramdom a défini un chiffre que l'utilisateur doit trouver le plus vite possible.
//A la fin du jeu, l'utilisateur est informé du nombre de tour qu'il a réalisé

using System;


namespace findNumberGame
{
    class Program
    {
        static void Main(string[] args) 
        {
            Random rand = new Random();
            int number = rand.Next(1, 101);
            int turn = 0; //Nombre de tour de jeu
            int myNumber = 0; //Nombre saisie
            string? response; //Ajout du ? pour prendre en compte qu'une valeur nulle peut être saisie
            while (myNumber != number) 
            {
                Console.WriteLine("Enter a number between 1 and 100"); //Consigne à suivre
                response = Console.ReadLine();
                try
                {
                    myNumber = Convert.ToInt16(response);
                    turn ++;
                    //Guider l'utilisateur
                    if (myNumber > number)
                    {
                        Console.WriteLine("The number is smaller than ", myNumber); 
                    }
                    else if (myNumber < number)
                    {
                        Console.WriteLine("The number is bigger than ", myNumber);
                    }
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Please, enter a integer"); //une mauvaise saisie a eu lieu
                }
            }
            //Jeu terminé
            Console.WriteLine($"Good Game, you find it in {turn}");
        }
    }
}
