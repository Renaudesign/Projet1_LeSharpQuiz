using System;
using System.Collections.Generic;

namespace quizzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // survey is an array of arrays made of strings.
            // Each inner array corresponds to a step in survey with 5 strings corresponding to :
            // 1. question 2. the answer 3. 4. & 5. other choices

            string[][] survey = new string[3][];
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
                @"\br",
                @"/n",
                @"/br",
                @"\n"
            };
            survey[2] = new string[]
            {
                @"Pourquoi les « truth tables » sont-elles utiles aux programmeurs ?",
                @"Une « truth table » répertorie tous les opérateurs booléens utilisés dans la programmation C #.",
                @"Les « truth tables » visualisent la sortie d'un opérateur booléen avec toutes les combinaisons possibles d'entrées.",
                @"Une table de vérité est un type de données en C # qui contient de nombreuses valeurs booléennes.",
                @"Aucune de ces 3 suggestions"
            };


            int[] userAnswers = new int[survey.Length];
            int userScore = 0;

            Console.WriteLine("Bienvenue dans le quizz C#. 10 questions vous seront posées pour vérfier vos connaissances. Pour chaque question vous seront proposées 4 réponses. Vous pouvez séléctionner une réponse en tapant la lettre associée <A>, <B>, <C> ou <D> puis valider avec <Entrée> et passer à la question suivante\nBon quizz!\n");

            void displayQuestion(string[] questionAnswers)
            {
                char incLetter = 'A';
                Console.WriteLine("\n" + questionAnswers[0]);
                    Console.WriteLine("------------------------");
                for (int i = 1; i < questionAnswers.Length; i++) {
                    Console.WriteLine($"{incLetter} - {questionAnswers[i]}");
                    incLetter++;
                    } 
            }
            int getAnswer()
            {
                int userChoice = 0;
                bool exit = false;
                ConsoleKeyInfo keyPress;

                Console.WriteLine("Appuyez sur les <A> <B> <C> <D> puis <Entrée> pour valider");
                while (!exit)
                {
                    // bool argument of ReadKey() is for hiding user key stroke on console
                    keyPress = Console.ReadKey(true);
                    Console.WriteLine($"Vous avez appuyé sur : < {keyPress.Key.ToString()} >");
                }

                return userChoice;
            }


            foreach (string[] question in survey)
            {
                displayQuestion(question);
                
            }

            for (int i = 0; i < survey.Length; i++)
            {
                displayQuestion(survey[i]);
                userAnswers[i] = getAnswer();
            }
            





        }
    }
}
