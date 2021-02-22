using System;

namespace Projet1_Quizz
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            Console.WriteLine("Le Quizzzzzz");
            Console.WriteLine("Entre votre genre");
            string genre = Console.ReadLine();
            
            Console.WriteLine("Entrez votre nom : ");
            string nom = Console.ReadLine();
            Console.WriteLine("Entrez votre prénom : ");
            string prenom = Console.ReadLine();
            Console.WriteLine($"Bonjour {genre} {nom} {prenom}, Bienvenue dans le quizz C#. \n 10 questions vous seront posées pour vérfier vos connaissances." +
                $"\n Pour chaque question vous seront proposées 4 réponses." +
                $"\n Vous pouvez séléctionner une réponse en tapant la lettre associée <A>, <B>, <C> ou <D> puis valider avec <Entrée>\nBon quizz!");
            Console.WriteLine("Taper entrée pour démarrer le test");
            Console.ReadKey();



           
        }
    }
}
