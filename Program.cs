using System;
using System.Collections.Generic;

namespace Projet1_Quizz
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Le Quizzzzzz");
            Console.WriteLine("Entrez votre nom : ");
            string nom = Console.ReadLine();
            Console.WriteLine("Entrez votre prénom : ");
            string prenom = Console.ReadLine();
            Console.WriteLine($"Bonjour {nom} {prenom}, Bienvenue dans le quizz C#. \n 10 questions vous seront posées pour vérfier vos connaissances." +
                $"\n Pour chaque question vous seront proposées 4 réponses." +
                $"\n Vous pouvez séléctionner une réponse en tapant la lettre associée <A>, <B>, <C> ou <D> puis valider avec <Entrée>\nBon quizz!");
            Console.WriteLine("Taper entrée pour démarrer le test");
            Console.ReadKey();

            Dictionary<string, string> question = new Dictionary<string, string>();
            question.Add("Quel est le lien entre la plateforme .NET et C# ?", "Les applications .NET peuvent être écrit en C#");
            question.Add("En C, quelle est la séquence d'échappement correcte pour mettre une nouvelle ligne dans une chaîne de caractère « string » ?", " \n ");
            question.Add("Pourquoi les « truth tables » sont-elles utiles aux programmeurs ?", "Les « truth tables » visualisent la sortie d'un opérateur booléen avec toutes les combinaisons possibles d'entrées.");
            question.Add("Lequel n'est pas un membre du groupe ?", "Object");
            question.Add("Qu'est-ce que LINQ ?", "Les fonctionnalités LINQ peuvent être utilisées dans un programme C # en important le namespace System.Linq ");
            question.Add("Quel est le nom d'une boucle qui ne se termine jamais ?", "Une boucle infinie. ");
            //question.Add("Quelle ligne de code écrit correctement Hello World sur la console ?", "Console.WriteLine("Hello World"); ");
            question.Add("En C #, comment s'appellent ces lignes de code ? /*Nothing to see here yet */ ", "Commentaire ");
            question.Add("Que fait arr[4], en supposant que arr est un tableau ?", "Accède au 5ème élément du tableau. ");
            question.Add("Quelle ligne de commande est utilisée pour lire une entrée(input) de l’utilisateur en C# ? ", "b.	Console.ReadLine() ;");

            string enterQuestionnaire;
            Console.WriteLine($" {question}Donnez la bonne réponse");
            enterQuestionnaire = Console.ReadLine().ToUpper();
            if (question.ContainsKey(enterQuestionnaire))
            {
                Console.WriteLine(question[enterQuestionnaire]);
            }
            else
            {
                Console.WriteLine("Entrer une valeur correcte");
            }
        }
    }
}
