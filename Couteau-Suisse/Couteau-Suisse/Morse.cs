using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couteau_Suisse
{
    internal class Morse
    {
        static string x = "";
        const int nbSymbols = 37;

        static string[,] table = new string[nbSymbols, 2] {
        {"A", ".-"},
        {"B", "-..."},
        {"C", "-.-."},
        {"D", "-.."},
        {"E", "."},
        {"F", "..-."},
        {"G", "--."},
        {"H", "...."},
        {"I", ".."},
        {"J", ".---"},
        {"K", "-.-"},
        {"L", ".-.."},
        {"M", "--"},
        {"N", "-."},
        {"O", "---"},
        {"P", ".--."},
        {"Q", "--.-"},
        {"R", ".-."},
        {"S", "..."},
        {"T", "-"},
        {"U", "..-"},
        {"V", "...-"},
        {"W", ".--"},
        {"X", "-..-"},
        {"Y", "-.--"},
        {"Z", "--.."},
        {" ", "/" },
        {"1", ".----" },
        {"2", "..---" },
        {"3", "...--" },
        {"4", "....-" },
        {"5", "....." },
        {"6", "-...." },
        {"7", "--..." },
        {"8", "---.." },
        {"9", "----." },
        {"0", "-----" },
        };
        public static void ConvertTextToMorse() {
            bool restartProgram = true;
            string restartChoise = null;
            bool repeat = false;
            Console.Clear();
            while (restartProgram == true)
            {
                Console.Write("Entrez le mot/phrase à convertir : ");
                x = Console.ReadLine();
                char[] word = x.ToCharArray();
                foreach (char c in word)
                {
                    for (int i = 0; i < nbSymbols; i++)
                    {
                        if (c.ToString().ToUpper() == table[i, 0])
                        {
                            Console.Write(table[i, 1] + " ");
                        }
                    }
                }
                Console.WriteLine("");
                do {
                    repeat = false;
                    Console.Write("Souhaitez-vous convertir encore un nombre en Morse? Oui -> (O), Non -> (N) : ");
                    restartChoise = Console.ReadLine();
                    if (restartChoise == "O" || restartChoise == "o" || restartChoise == "OUI" || restartChoise == "Oui")
                    {
                        restartProgram = true;

                    }
                    else if (restartChoise == "N" || restartChoise == "n" || restartChoise == "NON" || restartChoise == "Non")
                    {
                        restartProgram = false;
                    }
                    else
                    {
                        repeat = true;
                    }
                }while (repeat == true);
            }

        }
    }
}
