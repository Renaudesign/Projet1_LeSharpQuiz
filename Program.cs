using System;
using System.Collections.Generic;
using System.Linq;

namespace quizzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // survey is an array of arrays made of strings.
            // Each inner array corresponds to a step in survey with 5 strings corresponding to :
            // 1. question 2. the answer 3. 4. & 5. other choices


            string[][] survey = new string[10][];
            survey[0] = new string[] {
                @"Quel est le lien entre la plateforme .NET et C# ?",
                @"Les applications .NET peuvent être écrit en C#",
                @".NET fait partie de C#",
                @".NET est identique à C#",
                @".NET n'est pas lié à C#"
            };
            survey[1] = new string[]
            {
                @"En C, quelle est la séquence d'échappement correcte pour mettre une nouvelle ligne dans une chaîne de caractère « string » ?",
                @"\n",
                @"\br",
                @"/n",
                @"/br"

            };
            survey[2] = new string[]
            {
                @"Pourquoi les « truth tables » sont-elles utiles aux programmeurs ?",
                @"Les « truth tables » visualisent la sortie d'un opérateur booléen avec toutes les combinaisons possibles d'entrées",
                @"Une « truth table » répertorie tous les opérateurs booléens utilisés dans la programmation C #",
                @"Une table de vérité est un type de données en C # qui contient de nombreuses valeurs booléennes",
                @"Aucune de ces 3 suggestions"
            };
            survey[3] = new string[]
            {
                @"Lequel n'est pas un membre du groupe ?",
                @"Object",
                @"Constructor",
                @"Property",
                @"Method"

            };
            survey[4] = new string[]
            {
                @"Qu'est-ce que LINQ ?",
                @"Les fonctionnalités LINQ peuvent être utilisées dans un programme C# en important le namespace System.Linq",
                @"La liste et les types de dictionnaires",
                @"Les méthodes Select() et Where()",
                @"Une syntaxe de requéte unique"

            };
            survey[5] = new string[]
            {
                @"Quel est le nom d'une boucle qui ne se termine jamais ?",
                @"Une boucle infinie",
                @"Une boucle récurrente",
                @"Une boucle récursive",
                @"Une boucle sans terminaison"
            };
            survey[6] = new string[]
            {
                @"Quelle ligne de code écrit correctement ""Hello World"" sur la console ?",
                @"Console.WriteLine(""Hello World"");",
                @"Console(""Hello World"");",
                @"WriteLine(""Hello World"");",
                @"Console.WriteLine(‘Hello World’);"

            };
            survey[7] = new string[]
            {
                @"En C #, comment s'appellent ces lignes de code ? /*Nothing to see here yet */",
                @"Commentaire",
                @"Plateforme .NET",
                @"Commande",
                @"Sortie"
            };
            survey[8] = new string[]
            {
                @"Que fait arr [4], en supposant que arr est un tableau ?",
                @"Accède au 5ème élément du tableau",
                @"Redimensionne le tableau afin qu'il puisse stocker 4 éléments",
                @"Accède au 4ème élément du tableau",
                @"Supprimez l'élément de tableau à l'index 4"
            };
            survey[9] = new string[]
            {
                @"Quelle ligne de commande est utilisée pour lire une entrée(input) de l’utilisateur en C# ?",
                @"Console.ReadLine();",
                @"Console.writeLine();",
                @"Console.WriteLine();",
                @"Console.readLine();"
            };

            string[] userAnswers = new string[survey.Length];
            string[] goodAnswers = new string[survey.Length];
            int userScore = 0;

            Console.WriteLine("Bienvenue dans le quizz C#. 10 questions vous seront posées pour vérfier vos connaissances. Pour chaque question vous seront proposées 4 réponses. Vous pouvez séléctionner une réponse en tapant la lettre associée <A>, <B>, <C> ou <D> puis valider avec <Entrée> et passer à la question suivante\nBon quizz!\n");

            void displayQuestion(int questionNumber, string question, string[] choices)
            {
                char incLetter = 'A';
                Console.WriteLine($"\n {questionNumber}/ {question}"); 
                    Console.WriteLine("------------------------");
                foreach(string choice in choices)
                {
                    Console.WriteLine($"{incLetter} - {choice}");
                    incLetter++;
                }
            }
            int getUserChoice()
            {
                int userChoice = 0;
                bool exit = false;
                ConsoleKeyInfo keyPress;

                Console.WriteLine("Appuyez sur les <A> <B> <C> <D> puis <Entrée> pour valider");
                while (!exit)
                {
                    // bool argument of ReadKey() is for hiding user key stroke on console
                    keyPress = Console.ReadKey(true);
                    // Console.WriteLine($"Vous avez appuyé sur : < {keyPress.Key.ToString()} >");
                    if (keyPress.Key == ConsoleKey.A) userChoice = 1;
                    else if (keyPress.Key == ConsoleKey.B) userChoice = 2;
                    else if (keyPress.Key == ConsoleKey.C) userChoice = 3;
                    else if (keyPress.Key == ConsoleKey.D) userChoice = 4;
                    else if (keyPress.Key == ConsoleKey.Enter && userChoice != 0) exit = true;

                }

                return userChoice;
            }


            for (int i = 0; i < survey.Length; i++)
            {
                // 1st string in array is always question
                // 2nd string in array is the good answer
                // 3rd, 4th and 5th strings are other choices
                // All 4 choices get their order randomized and good answer get stored in variable
                string question = survey[i][0];
                string goodAnswer = survey[i][1];
                string[] choices = new string[] {
                survey[i][1],
                survey[i][2],
                survey[i][3],
                survey[i][4]
                };
                Random random = new Random();
                choices = choices.OrderBy(x => random.Next()).ToArray();
                displayQuestion(i + 1, question, choices);
                Console.WriteLine(" Choices array : " + choices);
                Console.WriteLine(choices[0]);
                
                userAnswers[i] = choices[getUserChoice() - 1];
                goodAnswers[i] = goodAnswer;

            }

            Console.WriteLine("Bravo, vous avez terminé le questionnaire. Voici la correction : ");
            for (int i = 0; i < survey.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}/ {survey[i][0]}");
                Console.WriteLine($"Vous avez répondu : \n {userAnswers[i]}");
                if (userAnswers[i] == goodAnswers[i])
                {
                    userScore++;
                    Console.WriteLine("C'était la bonne réponse. +1 point");
                } else
                {
                    Console.WriteLine($"La bonne réponse était : \n {goodAnswers[i]}");
                }
            }

            Console.WriteLine($" Vous obtenez le score de {userScore} points sur {survey.Length}");

        }
    }
}
