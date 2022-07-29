using IntroTraninigDay9;

namespace Exercies
{
    class Exercies
    {
        static void Main(string[] args)
        {
            Greet();
            Sum(5, 7);
            Division(7, 5);
            Operation1(-5, 8, 6);
            Operation2(55, 9, 9);
            Operation3(20, -3, 5, 8);
            Operation4(5, 15, 3, 2, 8, 3);

            Calculator c = new Calculator();
            Console.WriteLine("Rezultatul adunarii este: " + c.Adunare(2, 3));
            Console.WriteLine("Rezultatul Scaderii este: " + c.Scadere(3, 7));
            Console.WriteLine("Rezultatul Inmultirii este: " + c.Inmultire(5, 5));
            Console.WriteLine("Rezultatul Impartirii este: " + c.Impartire(25, 2));

            LogicalOp op = new LogicalOp();

            int biggest = op.CheckBiggerNumber(7, 8);
            Console.WriteLine("Numarul mai mare este: " + biggest);

            op.ComparisonText("FastIT");

            Console.WriteLine("Rezultatul este: " + op.ComparisonTextAndNumber("FastIT", 4));

            op.Amount(7);

            op.ThreeAndFour(5);

            op.Case(6);

            Console.WriteLine("Numarul este par(true) sau este impar(false): " + op.isNumberEven(3));

            Console.WriteLine("Persoana are sau nu are drept la vot: " + op.isEligibleToVote(18));

            Console.WriteLine("Numarul mai mare este " + op.theBiggestNumber(18, 5, 90));

            Console.WriteLine(Model());
            Console.WriteLine("Media numerelor este: " + Average(25, 2, 4));
            Console.WriteLine("Restul Impartirii este: " + Modulo(5, 2));

            Console.WriteLine("Transforma Gradele Fahrenheit in Grade Celsius");
            float convertGrade = float.Parse(Console.ReadLine());
            Console.WriteLine("Temperatura in grade Celsius este: " + Fahrenheit(convertGrade));

            Console.WriteLine("Transforma Inch in Metrii");
            double convertInch = (float) double.Parse(Console.ReadLine());
            Console.WriteLine("Rezultatul transforamrii este " + Inch(convertInch) + " m");

            Viteza(1, 0, 0, 1000);
            Cerc(30);

        }
        public static void Greet()
        {
            Console.WriteLine("Hello\nDenisa");
        }
        public static void Sum(int x, int y)
        {
            int z = x + y;
            Console.WriteLine("exercise 2: " + z);
        }

        public static void Division(int x, int y)
        {
            float z = (float)x / y;
            Console.WriteLine("exercise 3: " + z);
        }
        public static void Operation1(int x, int y, int z)
        {
            float w = x + (y * z);
            Console.WriteLine("exercise 4a: " + w);
        }

        public static void Operation2(int x, int y, int z)
        {
            float w = (x + y) % z;
            Console.WriteLine("exercise 4b: " + w);
        }

        public static void Operation3(int x, int y, int z, int u)
        {
            float w = x + (float)(y * z) / u;
            Console.WriteLine("exercise 4c: " + w);
        }
        public static void Operation4(int x, int y, int z, int u, int r, int t)
        {
            float w = x + y / z * u - r % t;
            Console.WriteLine("exercise 4c: " + w);
        }
       
        public static string Model()
        {
            String cSharp = "       C C C         /        /\n    C          -----/--------/-----\n    C              /        / \n    C             /        /\n    C        ----/--------/-----\n       C C C    /        /";
            return cSharp;
        }

        public static float Average(int x, int y, int z)
        {
            float result = (float) (x + y + z) / 3;
            return result;
        }
        public static float Modulo(float x, float y)
        {
            float result = (float) x % y;
            return result;
        }
        public static float Fahrenheit(float F)
        {
            float ConvertToCelsius = (float) 5 / 9 * (F - 32);
            return ConvertToCelsius;
        }
        public static double Inch(double i)
        {
            double ConvertToMeter = (double) i * 0.0254;
            return ConvertToMeter;
        }
        public static void Viteza(int min, int s, int h, float m)
        {
            float timp = h * 3600 + min * 60 + s;
            float vitezaMs = m / timp;
            float vitezaKmH = vitezaMs / 1000f * 3600f;
            float vitezaMH = vitezaKmH / 1.609f;
            Console.WriteLine("Rezultatul vitezei in metrii pe secunda " + vitezaMs);
            Console.WriteLine("Rezultatul vitezei in  kilometri pe ora " + vitezaKmH);
            Console.WriteLine("Rezultatul vitezei in  mile pe ora " + vitezaMH);
        }
        public static void Cerc(float r)
        {
            double aria = r * Math.PI;
            double perimetrul = 2 * r * Math.PI;

            Console.WriteLine("Aria cercului " + aria);
            Console.WriteLine("Perimetrul cercului " + perimetrul); 
        }

    }

}



