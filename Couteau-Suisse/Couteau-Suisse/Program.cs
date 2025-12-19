namespace Couteau_Suisse
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            bool programRestartValue = true;
            while (programRestartValue == true)
            {
                int choiseProgram = 0;
                bool valueIsOk = true;
                Console.Clear();
                Console.WriteLine("=== Couteau Suisse – Utilitaires ===");
                Console.WriteLine("1. Convertir du texte en code Morse");
                Console.WriteLine("2. Convertir des nombres entre différentes bases (Décimal <> Binaire <> Octal)");
                Console.WriteLine("3. Chiffrer une phrase avec César");
                Console.WriteLine("4. Quitter le programme");
                Console.Write("Veuillez entrer votre choix : ");

                valueIsOk = int.TryParse(Console.ReadLine(), out choiseProgram);

                if (choiseProgram == 1)
                {
                    Morse.ConvertTextToMorse();
                    programRestartValue = true;
                }
                if(choiseProgram == 2)
                {
                    Console.Clear();
                    Console.WriteLine("1. Décimal > Binaire");
                    Console.WriteLine("2. Binaire > Décimal");
                    Console.WriteLine("3. Binaire > Octal");
                    Console.WriteLine("4. Octal > Binaire");
                    Console.WriteLine("5. Retourner à la page précédente");
                    valueIsOk = int.TryParse(Console.ReadLine(), out choiseProgram);
                    if (choiseProgram == 1)
                    {
                        ConvertBases.ConvertDecimalBinary();
                    }
                    else if (choiseProgram == 2)
                    {
                        ConvertBases.ConvertBinaryDecimal();
                    }
                    else if (choiseProgram == 3)
                    {
                        ConvertBases.ConvertBinaryOctal();
                    }
                    else if (choiseProgram == 4)
                    {
                        ConvertBases.ConvertOctalBinary();
                    }
                    else if (choiseProgram == 5)
                    {
                        programRestartValue = true;
                    }

                }
                else if (choiseProgram == 3)
                {
                    Cesar.ChiffrerMessage();
                }
                else if (choiseProgram == 4)
                { 
                    programRestartValue = false;
                }
            }
                
        }
    }
}
