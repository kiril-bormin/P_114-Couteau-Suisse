string x = "";
const int nbSymbols = 37;

string[,] table = new string[nbSymbols, 2] {
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
while (true) { 
    Console.Write("Entrez le mot/phrase à convertir : ");
    x = Console.ReadLine();
    char[] word = x.ToCharArray();
    foreach (char c in word)
    {
        for (int i = 0; i < nbSymbols; i++)
        {
            if (c.ToString().ToUpper() == table[i,0]) {
               Console.Write(table[i,1] + " ");
            }
        }
    }
    Console.WriteLine();
}


