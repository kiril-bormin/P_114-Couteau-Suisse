﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Couteau_Suisse
{
    internal class ConvertBases
    {
        static int numberToConvert = 0;
        static bool valueIsOk = true;
        public static void ConvertDecimalBinary()
        {
            bool restartProgram = true;
            string restartChoise = null;
            bool repeat = false;
            Console.Clear();
            while (restartProgram == true)
            {
                Console.Write("Entrez le nombre décimal (de 0 jusqu'à 255) à convertir en binaire : ");
                valueIsOk = int.TryParse(Console.ReadLine(), out numberToConvert);

                if (valueIsOk && numberToConvert >= 0)
                {
                    string binaryResult = DecimalToBinary(numberToConvert);
                    Console.WriteLine($"Le nombre {numberToConvert} en binaire est : {binaryResult}");
                }
                else
                {
                    Console.WriteLine("Entrée invalide. Veuillez entrer un nombre entier positif.");
                }
                do
                {
                    repeat = false;
                    Console.Write("Souhaitez-vous convertir encore un nombre en Binaire? Oui -> (O), Non -> (N) : ");
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
                } while (repeat == true);
                Console.Clear();
            }
        }
        public static string DecimalToBinary(int numberToConvert)
        {
            string resultBinary;
            int temp;
            int i = 1;

            char[] digits = {'0','0','0','0','0','0','0','0'};

            while (numberToConvert > 0)
            {
                temp = numberToConvert % 2;
                numberToConvert /= 2;

                if (temp == 1)
                {
                    digits[digits.Length - i] = '1';
                }
                i++;
                temp = 0;
            }
            resultBinary = new string(digits);
            return resultBinary;
        }
        public static void ConvertBinaryDecimal()
        {
            bool restartProgram = true;
            string restartChoise = null;
            bool repeat = false;
            Console.Clear();
            while (restartProgram == true)
            {
                Console.Write("Entrez le nombre décimal (de 0 jusqu'à 255) à convertir en binaire : ");
                valueIsOk = int.TryParse(Console.ReadLine(), out numberToConvert);

                if (valueIsOk && numberToConvert >= 0)
                {
                    string binaryResult = DecimalToBinary(numberToConvert);
                    Console.WriteLine($"Le nombre {numberToConvert} en binaire est : {binaryResult}");
                }
                else
                {
                    Console.WriteLine("Entrée invalide. Veuillez entrer un nombre entier positif.");
                }
                do
                {
                    repeat = false;
                    Console.Write("Souhaitez-vous convertir encore un nombre en Binaire? Oui -> (O), Non -> (N) : ");
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
                } while (repeat == true);
                Console.Clear();
            }
        }
    }
}