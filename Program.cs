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

            string[][] blocks = new string[10][];
            blocks[0] = new string[] {
                @"Quel est le lien entre la plateforme .NET et C# ?",
                @"Les applications .NET peuvent être écrit en C#",
                @".NET fait partie de C#",
                @".NET est identique à C#",
                @".NET n'est pas lié à C#"
            };
            blocks[1] = new string[]
            {
                @"En C, quelle est la séquence d'échappement correcte pour mettre une nouvelle ligne dans une chaîne de caractère « string » ?",
                @"\n",
                @"\br",
                @"/n",
                @"/br"
                
            };
            blocks[2] = new string[]
            {
                @"Pourquoi les « truth tables » sont-elles utiles aux programmeurs ?",
                @"Les « truth tables » visualisent la sortie d'un opérateur booléen avec toutes les combinaisons possibles d'entrées",
                @"Une « truth table » répertorie tous les opérateurs booléens utilisés dans la programmation C #",              
                @"Une table de vérité est un type de données en C # qui contient de nombreuses valeurs booléennes", 
                @"Aucune de ces 3 suggestions"
            };
            blocks[3] = new string[]
            {
                @"Lequel n'est pas un membre du groupe ?",
                @"Object",
                @"Constructor", 
                @"Property", 
                @"Method"
                
            };
            blocks[4] = new string[]
            {
                @"Qu'est-ce que LINQ ?", 
                @"Les fonctionnalités LINQ peuvent être utilisées dans un programme C# en important le namespace System.Linq",
                @"La liste et les types de dictionnaires", 
                @"Les méthodes Select() et Where()", 
                @"Une syntaxe de requéte unique" 
                
            };
            blocks[5] = new string[]
            {
                @"Quel est le nom d'une boucle qui ne se termine jamais ?",
                @"Une boucle infinie",
                @"Une boucle récurrente",
                @"Une boucle récursive",
                @"Une boucle sans terminaison"
            };
            blocks[6] = new string[]
            {
                @"Quelle ligne de code écrit correctement ""Hello World"" sur la console ?",
                @"Console.WriteLine(""Hello World"");",
                @"Console(""Hello World"");",
                @"WriteLine(""Hello World"");",
                @"Console.WriteLine(‘Hello World’);"
               
            };
            blocks[7] = new string[]
            {
                @"En C #, comment s'appellent ces lignes de code ? /*Nothing to see here yet */",
                @"Commentaire",
                @"Plateforme .NET",
                @"Commande",
                @"Sortie"
            };
            blocks[8] = new string[]
            {
                @"Que fait arr [4], en supposant que arr est un tableau ?",
                @"Accède au 5ème élément du tableau",
                @"Redimensionne le tableau afin qu'il puisse stocker 4 éléments",
                @"Accède au 4ème élément du tableau",
                @"Supprimez l'élément de tableau à l'index 4"
            };
            blocks[9] = new string[]
            {
                @"Quelle ligne de commande est utilisée pour lire une entrée(input) de l’utilisateur en C# ?",
                @"Console.ReadLine();",
                @"Console.writeLine();",
                @"Console.WriteLine();",
                @"Console.readLine();"
            };

            // A la fin du quiz, vous devrez afficher un récapitulatif en donnant le score du candidat et les bonnes réponses.
            ($"Bravo {nom} {prenom}, votre score est de {} voici les bonnes réponses au questionnaire {}");

        }
    }
}
