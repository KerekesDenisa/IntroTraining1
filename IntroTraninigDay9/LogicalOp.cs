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
        public void Counting1(int number)
        {
            Console.WriteLine("Numaratoarea pana la 100 este ");
            while (number < 100)
            {
                Console.Write(number + " ");
                number ++;
            }
        }
        public void CountingNegative1(int number)
        {
            Console.WriteLine("\nNumaratoarea pana la -100 este ");
            while (number > -100)
            {
                Console.Write(number + " ");
                number--;
            }
        }
        public void CountingBetweenNumbers1(int m, int n)
        {
            Console.Write("\nNumaratoarea intre numere este ");

            while (m < n)
            {
                Console.Write(m + " ");
                m++;
            }
            while (n < m)
            {
                Console.Write(m + " ");
                m--;
            }
        }

        public void CountingIncreasingNumbers1(int x, int y)
        {
            Console.Write("\nNumaratoarea crescatoare este ");

            if (x <= y)
                while (x <= y)
                {
                    Console.Write(x + " ");
                    x++;
                }

            else while (y <= x)
                {
                    Console.Write(y + " ");
                    y++;
                }
        }
        public void EvenNumbers1()
        {
            Console.Write("\nNumaratoarea nr pare este ");

            int i = 2;
            while (i <= 100)
            {
                Console.Write(i + " ");
                i = i + 2;
            }
        }
        public void OddNumbers1()
        {
            Console.Write("\nNumaratoarea nr impare este ");

            int i = 1;
            while (i <= 100)
            {
                Console.Write(i + " ");
                i = i + 2;
            }
        }
        public void SumAverage()
        {
            int i = 111, s = 0, count = 0;
            while (i <= 8899)
            {
                s = s + i;
                count++;
                i++;
            }

            Console.WriteLine("Sum: " + s);
            Console.WriteLine("Average: " + ((float)s / count));
        }
        public float Divisible(int x, int y)
        {
            int cont = 0, suma = 0;
            while (x <= y)
            {
                if (x % 7 == 0)
                {
                    suma = suma + x;
                    cont++;

                }
                x++;
            }

            while (y <= x)
            {
                if (y % 7 == 0)
                {
                    suma = suma + y;
                    cont++;

                }
                y++;
            }

            return (float)suma / cont;
        }

        public void Fibonacci()
        {
            int x = 0, y = 1, z = 0, cont = 2;
            Console.Write("Sirul lui Fibonacci: " + x + " " + y);
            while (cont < 20)
            {
                z = x + y;
                x = y;
                y = z;
                Console.Write(" " + z);
                cont++;
            }
        }

        public void CozaLozaWoza()
        {
            int i = 1;
            while (i <= 110)
            {
                if (i % 105 == 0)
                    Console.Write("\nCozaLozaWoza ");
                else if (i % 35 == 0)
                    Console.Write("\nWozaLoza ");
                else if (i % 21 == 0)
                    Console.Write("\nCozaWoza ");
                else if (i % 15 == 0)
                    Console.Write("\nCozaLoza  ");
                else if (i % 7 == 0)
                    Console.Write("\nWoza  ");
                else if (i % 5 == 0)
                    Console.Write("\nLoza  ");
                else if (i % 3 == 0)
                    Console.Write("\nCoza  ");
                else Console.Write(i + " ");
                if (i % 11 == 0)
                    Console.WriteLine();

                i++;
            }
        }

        public void Array1H()
        {
            int[] arr = new int[100];
            for (int i = 0; i < 100; i++)
            {
                arr[i] = i + 1;
                Console.Write(arr[i] + " ");
            }
        }
        public int[] EvenNumbers2(int[] arr)
        {
            int j = 0;
            for (int i = 2; i <= 100; i = i + 2)
            {

                arr[j] = i;
                j++;
            }
            return arr;
        }

        public float AverrageNumbers1(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum = sum + arr[i];
            return (float)sum / arr.Length;
        }
        public bool FindWord(string[] arr, string text)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i].Equals(text))
                    return true;
            return false;
        }
        public int NumberPosition(int[] arr, int nr)
        {
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] == nr)
                    return i;
            return -1;
        }
        public void Grid()
        {
            string[] arr = new string[] { "-", "-", "-", "-", "-", "-", "-", "-", "-", "-" };
            for (int j = 0; j < arr.Length; j++)
            {
                for (int i = 0; i < arr.Length; i++)
                    Console.Write(arr[i]);
                Console.WriteLine();
            }
        }

        public int[] WithoutNumber(int[] arr, int nr)
        {
            int i = 0;
            while (i < arr.Length)
            {
                if (arr[i] == nr)
                {
                    for (int j = i; j < arr.Length - 1; j++)
                        arr[j] = arr[j + 1];
                    Array.Resize(ref arr, arr.Length - 1);
                }

                i++;
            }
            return arr;
        }
        public int SecondMinNumber(int[] arr)
        {
            int second = Int32.MaxValue, second2 = Int32.MaxValue;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] < second)
                {
                    second2 = second;
                    second = arr[i];
                }
                else if (arr[i] < second2)
                    second2 = arr[i];
            return second2;
        }

        public int[] Transfer(int[] arr, int[] arrSecond)
        {
            for (int i = 0; i < arr.Length; i++)
                arrSecond[i] = arr[i];
            return arrSecond;
        }
    }
}
