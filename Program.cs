using System;

namespace Projet1_Quizz
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Console.WriteLine("Le Quizzzzzz");
            Console.WriteLine("Entrez votre nom : ");
            string snom = Console.ReadLine();
            Console.WriteLine("Entrez votre prénom : ");
            string sprenom = Console.ReadLine();
            Console.WriteLine($"Bonjour {snom} {sprenom}, Bienvenue à notre quiz, êtes-vous prêt à améliorer vos connaissance en C# ? ");
            Console.WriteLine("Tapez entrée pour démarrer le test");
            Console.ReadKey();
            
        }
    }
}
