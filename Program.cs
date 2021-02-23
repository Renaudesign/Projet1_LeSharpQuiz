using System;
using System.Collections.Generic;

namespace quizzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction du test avec demande d'infos
            
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("---------------------" +
                              "\n|| Le Sharp Quizz ||" +
                              "\n---------------------");
                                

            Console.WriteLine("\nEntrez votre nom : ");
            string nom = Console.ReadLine();
            Console.WriteLine("\nEntrez votre prénom : ");
            string prenom = Console.ReadLine();
            Console.WriteLine($"\nBonjour {nom} {prenom}, Bienvenue dans le quizz C#. \n\n10 questions vous seront posées pour vérfier vos connaissances." +
                $"\nPour chaque question vous seront proposées 4 réponses." +
                $"\nVous pouvez séléctionner une réponse en tapant la lettre associée <A>, <B>, <C> ou <D> puis valider avec <Entrée>\n\nBon quizz!");
            

            //Loop de vérification sur la touche Entrée pour lancer le test
            bool startTest = false;
            do
            {
                Console.WriteLine("\nTapez entrée pour démarrer le test");
                ConsoleKeyInfo checkKey = Console.ReadKey(true);
                if (checkKey.Key == ConsoleKey.Enter)
                {
                    startTest = true;};
            } while (!startTest);
            
            Console.Clear();



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


            int[] userAnswers = new int[survey.Length];
            int userScore = 0;

            void displayQuestion(string[] questionAnswers)
            {
                char incLetter = 'A';
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n" + questionAnswers[0]);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("------------------------");
                for (int i = 1; i < questionAnswers.Length; i++)
                {
                    Console.WriteLine($"{incLetter} - {questionAnswers[i]}");
                    incLetter++;}
            }
            int getAnswer()
            {
                int userChoice = 0;
                bool exit = false;
                ConsoleKeyInfo keyPress;

                Console.WriteLine("\nAppuyez sur les <A> <B> <C> <D> puis <Entrée> pour valider");
                while (!exit)
                {
                    // bool argument of ReadKey() is for hiding user key stroke on console
                    keyPress = Console.ReadKey(true);

                    // modifier l'entrée du tableau pour lui ajouter les pipes signifiant qu'elle est sélectionnée

                    Console.WriteLine($"Vous avez appuyé sur : < {keyPress.Key.ToString()} >");
                    if (keyPress.Key == ConsoleKey.A)
                    {
                        userChoice = 1;}
                    else if (keyPress.Key == ConsoleKey.B)
                    {
                        userChoice = 2;}
                    else if (keyPress.Key == ConsoleKey.C)
                    {
                        userChoice = 3;}
                    else if (keyPress.Key == ConsoleKey.D)
                    {
                        userChoice = 4;}
                    else if (keyPress.Key == ConsoleKey.Enter && userChoice != 0)
                    {
                        exit = true;
                        Console.Clear();}


                    Console.WriteLine("Vous avez choisi la reponse : " + userChoice);

                }

                return userChoice;

            }


            for (int i = 0; i < survey.Length; i++)
            {
                displayQuestion(survey[i]);
                userAnswers[i] = getAnswer();
                if (userAnswers[i] == 1) userScore++;
            }
            // A la fin du quizz, vous devrez afficher un récapitulatif en donnant le score du candidat et les bonnes réponses.
            Console.WriteLine($"Bravo {nom} {prenom}, votre score est de {userScore} sur {survey.Length}.\ndVoici les bonnes réponses au questionnaire: ");




        }


    }
}

