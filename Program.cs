namespace LesChiffresRomains
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inputChiffreRomains = "";
            string[] divideChiffresRomains = new string[inputChiffreRomains.Length];
            int[] convertedNumbers = new int[divideChiffresRomains.Length];

            while (true)
            {
                Console.WriteLine("\n\n=======Les Chiffres Romains=======");
                Console.WriteLine("\nVeuillez entrer un chiffres romains : ");
                inputChiffreRomains = Console.ReadLine();
                inputChiffreRomains = inputChiffreRomains.ToUpper();

                Program program = new Program();
                divideChiffresRomains = program.DivideChiffresRomains(inputChiffreRomains);
                convertedNumbers = program.ConvertChiffresRomains(divideChiffresRomains);
                program.DisplayResultat(convertedNumbers, divideChiffresRomains);
            }
        }

        public string[] DivideChiffresRomains(string inputChiffreRomains)
        {
            string[] arrayDivideChiffresRomains = new string[inputChiffreRomains.Length];
            int j = 0;
            
            for(int i = 0; i < inputChiffreRomains.Length; i++)
            {
                if (inputChiffreRomains[i] == 'I')
                {
                    if(i < (inputChiffreRomains.Length - 1))
                    {
                        if (inputChiffreRomains[i + 1] == 'V' || inputChiffreRomains[i + 1] == 'X')
                        {
                            arrayDivideChiffresRomains[j] = inputChiffreRomains[i].ToString() + inputChiffreRomains[i + 1].ToString();
                            j++;
                            i++;
                        }
                        else
                        {
                            arrayDivideChiffresRomains[j] = inputChiffreRomains[i].ToString();
                            j++;
                        }
                    }
                    else
                    {
                        arrayDivideChiffresRomains[j] = inputChiffreRomains[i].ToString();
                        j++;
                    }

                }
                else if (char.ToUpper(inputChiffreRomains[i]) == 'X')
                {
                    if (i < (inputChiffreRomains.Length - 1))
                    {
                        if (inputChiffreRomains[i + 1] == 'L' || inputChiffreRomains[i + 1] == 'C')
                        {
                            arrayDivideChiffresRomains[j] = inputChiffreRomains[i].ToString() + inputChiffreRomains[i + 1].ToString();
                            j++;
                            i++;
                        }
                        else
                        {
                            arrayDivideChiffresRomains[j] = inputChiffreRomains[i].ToString();
                            j++;
                        }
                    }
                    else
                    {
                        arrayDivideChiffresRomains[j] = inputChiffreRomains[i].ToString();
                        j++;
                    }
                }
                else if (char.ToUpper(inputChiffreRomains[i]) == 'C')
                {
                    if (i < (inputChiffreRomains.Length - 1))
                    {
                        if (inputChiffreRomains[i + 1] == 'D' || inputChiffreRomains[i + 1] == 'M')
                        {
                            arrayDivideChiffresRomains[j] = inputChiffreRomains[i].ToString() + inputChiffreRomains[i + 1].ToString();
                            j++;
                            i++;
                        }
                        else
                        {
                            arrayDivideChiffresRomains[j] = inputChiffreRomains[i].ToString();
                            j++;
                        }
                    }
                    else
                    {
                        arrayDivideChiffresRomains[j] = inputChiffreRomains[i].ToString();
                        j++;
                    }
                }
                else
                {
                    arrayDivideChiffresRomains[j] = inputChiffreRomains[i].ToString();
                    j++;
                }
            }

            return arrayDivideChiffresRomains;
        }
        public int[] ConvertChiffresRomains(string[] divideChiffresRomains)
        {
            int[] convertedNumbers = new int[divideChiffresRomains.Length];
            int j = 0;
            foreach(string str in divideChiffresRomains)
            {
                convertedNumbers[j] = GetNumber(str);
                j++;
            }

            return convertedNumbers;
        }

        public int GetNumber(string chiffreRomain)
        {
            int chiffre;
            if (chiffreRomain == "IV")
                chiffre = 4;
            else if (chiffreRomain == "IX")
                chiffre = 9;
            else if (chiffreRomain == "XL")
                chiffre = 40;
            else if (chiffreRomain == "XC")
                chiffre = 90;
            else if (chiffreRomain == "CD")
                chiffre = 400;
            else if (chiffreRomain == "CM")
                chiffre = 900;
            else if (chiffreRomain == "I")
                chiffre = 1;
            else if (chiffreRomain == "V")
                chiffre = 5;
            else if (chiffreRomain == "X")
                chiffre = 10;
            else if (chiffreRomain == "L")
                chiffre = 50;
            else if (chiffreRomain == "C")
                chiffre = 100;
            else if (chiffreRomain == "D")
                chiffre = 500;
            else if (chiffreRomain == "M")
                chiffre = 1000;
            else
                chiffre = 0;
            return chiffre;
        }

        public void DisplayResultat(int[] convertedNumbers, string[] divideChiffresRomains)
        {
            int resultat = convertedNumbers.Sum();
            string explication = "";
            Console.WriteLine("Resultat : " + resultat);
            foreach (string str in divideChiffresRomains)
            {
                if(!string.IsNullOrEmpty(str))
                {
                    explication += str + " = " + GetNumber(str) + ", ";
                }                    
            }
            Console.WriteLine("Explication : " + explication + ".");
        }
    }
   
}
