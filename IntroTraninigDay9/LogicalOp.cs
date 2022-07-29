using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroTraninigDay9
{
    public class LogicalOp
    {
        public int CheckBiggerNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
        public void ComparisonText(string text)
        {

            if (text.Equals("FastTrackIT"))
            {
                Console.WriteLine("Textele sunt la fel");
            }
            else
            {
                Console.WriteLine("Textele nu sunt la fel!");
            }
        }
        public string ComparisonTextAndNumber(string text, int number)
        {
            String Rez = "";

            if (text.Equals("FastTrackIT") && number <= 3)
            {
                Rez = text + number;
            }
            else if (!text.Equals("FastTrackIT") && number >= 4)
            {
                Rez = number + text;
            }
            return Rez;
        }
        public void Amount(int number)
        {

            if (number > 8 || number == 6)
            {
                Console.WriteLine("The amount of snow this winter was(cm): " + number);
            }
            else
            {
                Console.WriteLine("The forecast snow is(cm): " + number);
            }
        }
        public void ThreeAndFour(int number)
        {
            if (number > 3 && number != 4)
            {
                Console.WriteLine("The number is greater than 3 and not equal to 4.");
            }
            else if (number == 4)
            {
                Console.WriteLine("The number is equal to 4");
            }
            else
            {
                Console.WriteLine("The number is lower or equal to 3");
            }
        }
        public void Case(int number)
        {

            switch (number)
            {
                case 1:
                    Console.WriteLine("The number is 1");
                    break;
                case 2:
                    Console.WriteLine("The number is 2");
                    break;
                case 3:
                    Console.WriteLine("The number is 3");
                    break;
                case 4:
                    Console.WriteLine("The number is 4");
                    break;
                case 5:
                    Console.WriteLine("The number is 5");
                    break;
                case 6:
                    Console.WriteLine("The number is 6");
                    break;
                case 7:
                    Console.WriteLine("The number is 7");
                    break;
                default:
                    Console.WriteLine("NOT IDENTIFY");
                    break;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsEligibleToVote(int age)
        {
            if (age < 18)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public int TheBiggestNumber(int x, int y, int z)
        {
            int max = x;
            if (y > max)
                max = y;
            if (z > max)
                max = z;

            return max;
        }
        public void Counting(int number)
        {
            for (int i = number; i <= 100; i++)
            {
                Console.WriteLine("Numaratoarea pana la 100 este " + i);
            }
        }
        public void CountingNegative(int number)
        {
            for (int i = number; i >= -100; i--)
            {
                Console.WriteLine("Numaratoarea pana la -100 este " + i);
            }
        }
        public void CountingBetweenNumbers(int m, int n)
        {
            Console.Write("Numaratoarea intre numere este ");

            if (m < n)
            {
                for (int i = m; i <= n; i++)
                    Console.Write(i + " ");
            }
            else
            {
                for (int i = m; i >= n; i--)
                    Console.Write(i + " ");
            }
        }
        public void CountingIncreasingNumbers(int m, int n)
        {
            Console.Write("Numaratoarea crescatoare este ");

            if (m < n)
            {
                for (int i = m; i <= n; i++)
                    Console.Write(i + " ");
            }
            else
            {
                for (int i = n; i <= m; i++)
                    Console.Write(i + " ");
            }
        }

        public void EvenNumbers()
        {
            Console.Write("Numaratoarea nr pare este ");

            for (int i = 2; i <= 100; i = i + 2)
                Console.Write(i + " ");
        }
        public void OddNumbers()
        {
            Console.Write("Numaratoarea nr impare este ");

            for (int i = 1; i <= 100; i = i + 2)
                Console.Write(i + " ");
        }
        public int SumNumbers(int n)
        {
            int suma = 0;

            if (n <= 100)

                for (int i = n; i <= 100; i++)
                    suma = suma + i;

            else
                for (int i = n; i >= 100; i--)
                    suma = suma + i;

            return suma;

        }
        public float AverrageNumbers(int n)
        {
            int suma = 0;

            if (n <= 100)
            {
                for (int i = n; i <= 100; i++)
                    suma = suma + i;

                return suma / (100 - n + 1);
            }
            else
            {
                for (int i = n; i >= 100; i--)
                    suma = suma + i;

                return suma / (n - 100 + 1);
            }
        }
        public void Stars()
        {
           for (int i = 0; i < 7; i++)
            {
                for(int j = 7-i; j > 0; j--)
                    Console.Write("*");

                Console.WriteLine();
            }
        }
    }
}
