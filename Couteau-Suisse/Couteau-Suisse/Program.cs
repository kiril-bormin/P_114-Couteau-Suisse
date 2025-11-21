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
                Console.WriteLine("3. (à venir)");
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
                    ConvertBases.ConvertDecimalBinary();
                }
                else if (choiseProgram == 4)
                { 
                    programRestartValue = false;
                }
            }
                
        }
    }
}
