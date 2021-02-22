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
                @"\br",
                @"/n",
                @"/br",
                @"\n"
            };

            int userScore = 0;

            Console.WriteLine("Bienvenue dans le quizz c#. 10 questions vous seront posées pour vérfier vos connaissances. Pour chaque question vous seront proposées 4 réponses. Vous pouvez séléctionner une réponse en tapant la lettre associée <A>, <B>, <C> ou <D> puis valider avec <Entrée> et passer à la question suivante\nBon quizz!");


            foreach (string[] block in survey)
            {
                foreach (string element in block)
                {
                    Console.WriteLine(element);
                }
            }







        }
    }
}
