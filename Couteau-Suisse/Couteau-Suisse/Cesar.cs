using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couteau_Suisse
{
    internal class Cesar
    {
        static string[,] table = new string[26, 2] {
            {"A", "0"},
            {"B", "1"},
            {"C", "2"},
            {"D", "3"},
            {"E", "4"},
            {"F", "5"},
            {"G", "6"},
            {"H", "7"},
            {"I", "8"},
            {"J", "9"},
            {"K", "10"},
            {"L", "11"},
            {"M", "12"},
            {"N", "13"},
            {"O", "14"},
            {"P", "15"}, 
            {"Q", "16"},
            {"R", "17"},
            {"S", "18"},
            {"T", "19"},
            {"U", "20"},
            {"V", "21"},
            {"W", "22"},
            {"X", "23"},
            {"Y", "24"},
            {"Z", "25"}
        };

        public static void ChiffrerMessage()
        {
            bool restartProgram = true;
            string restartChoise = null;
            bool repeat = false;
            string input = "";
            int gap = 0;

            Console.Clear();

            while (restartProgram == true)
            {
                Console.Write("Entrez le message à chiffrer : ");
                input = Console.ReadLine().ToUpper();

                Console.Write("Entrez le décalage (entier, ex.: 3) : ");

                while (!int.TryParse(Console.ReadLine(), out gap))
                {
                    Console.Write("Erreur, entrer un nombre valide : ");
                }

                Console.Write("Resultat : ");

                foreach (char c in input)
                {
                    string charToString = c.ToString();
                    bool letterFound = false;
                    int currentIndex = -1;

                    for (int i = 0; i < 26; i++)
                    {
                        if (table[i, 0] == charToString)
                        {
                            currentIndex = int.Parse(table[i, 1]);
                            letterFound = true;
                            break; 
                        }
                    }
                    if (letterFound)
                    {
                        int newIndex = (currentIndex + gap) % 26;
                        if (newIndex < 0)
                        {
                            newIndex += 26;
                        }

                        Console.Write(table[newIndex, 0]);
                    }
                    else
                    {
                        Console.Write(c);
                    }
                }
                do
                {
                    repeat = false;
                    Console.Write("Souhaitez-vous chiffrer un autre message ? Oui -> (O), Non -> (N) : ");
                    restartChoise = Console.ReadLine();

                    if (restartChoise == "O" || restartChoise == "o" || restartChoise == "OUI" || restartChoise == "Oui")
                    {
                        restartProgram = true;
                        Console.Clear();
                    }
                    else if (restartChoise == "N" || restartChoise == "n" || restartChoise == "NON" || restartChoise == "Non")
                    {
                        restartProgram = false;
                    }
                    else
                    {
                        repeat = true;
                    }
                } while (repeat == true);
            }
        }
    }
}