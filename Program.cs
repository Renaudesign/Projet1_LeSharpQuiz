using System;
using System.Collections.Generic;

namespace Projet1_Quizz
{
    class Program
    {
        static void Main(string[] args)
        {

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


        
            
        var questions = new string[] 
        { 
            "Question 1: Quel est le lien entre la plateforme .NET et C# ? Answers: a)Les applications .NET peuvent être écrit en C#,  b).NET fait partie de C#, c).NET est identique à C#, d).NET n’est pas lié à C#. Select la bonne réponse (a,b,c or d) ",
            "Question 2: En C#, quelle est la séquence d'échappement correcte pour mettre une nouvelle ligne dans une chaîne de caractère « string » ? Answers: a)\br, b)/n, c)/br, d)\n.Select la bonne réponse (a,b,c or d) ",
            "Question 3: Pourquoi les « truth tables » sont-elles utiles aux programmeurs ? Answers: a)Une « truth table » répertorie tous les opérateurs booléens utilisés dans la programmation C #, b)Les « truth tables » visualisent la sortie d'un opérateur booléen avec toutes les combinaisons possibles d'entrées, c)Une table de vérité est un type de données en C # qui contient de nombreuses valeurs booléennes. d)Aucune de ces 3 suggestions. Select la bonne réponse (a,b,c or d) ",
            "Question 4: Lequel n'est pas un membre du groupe ? Answers: a)Constructor, b)Property, c)Method, d)Object. Select la bonne réponse (a,b,c or d) ",
            "Question 5: Qu'est-ce que LINQ ? Answers: a. La liste et les types de dictionnaires, b)Les méthodes Select() et Where(), c)Une syntaxe de requéte unique, d)Les fonctionnalités LINQ peuvent être utilisées dans un programme C# en important le namespace System.Linq. Select la bonne réponse (a,b,c or d) ",
            "Question 6: Quelle ligne de code écrit correctement Hello World sur la console ? Answers: a)Les applications .NET peuvent être écrit en C#,  b).NET fait partie de C#, c).NET est identique à C#, d).NET n’est pas lié à C#. Select la bonne réponse (a,b,c or d) ",
            "Question 7: En C #, comment s'appellent ces lignes de code ? /*Nothing to see here yet */ . Answers: a)Les applications .NET peuvent être écrit en C#,  b).NET fait partie de C#, c).NET est identique à C#, d).NET n’est pas lié à C#. Select la bonne réponse (a,b,c or d) ",
                "Question 8: Que fait arr[4], en supposant que arr est un tableau ? Answers: a)Les applications .NET peuvent être écrit en C#,  b).NET fait partie de C#, c).NET est identique à C#, d).NET n’est pas lié à C#. Select la bonne réponse (a,b,c or d) ",
                "Question 9: Quelle ligne de commande est utilisée pour lire une entrée(input) de l’utilisateur en C# ?   Answers: a)Les applications .NET peuvent être écrit en C#,  b).NET fait partie de C#, c).NET est identique à C#, d).NET n’est pas lié à C#. Select la bonne réponse (a,b,c or d) ",
                "Question 10: Quel est le nom d'une boucle qui ne se termine jamais ? Answers: a)Les applications .NET peuvent être écrit en C#,  b).NET fait partie de C#, c).NET est identique à C#, d).NET n’est pas lié à C#. Select la bonne réponse (a,b,c or d) ",
            };
            




            /*
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
            =question.Add("Quelle ligne de code écrit correctement Hello World sur la console ?", "Console.WriteLine("Hello World"); ");
            question.Add("En C #, comment s'appellent ces lignes de code ? Nothing to see here yet  ", "Commentaire ");
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
            
            */

        }
    }
}
