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
    }

}



