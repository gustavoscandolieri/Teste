namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Olá Mundo!");

          //  System.Console.WriteLine("{0}", Fibonacci(4));

            Fibonacci2(11);

            System.Console.ReadKey();


        }

        public static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return  Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static void Fibonacci2(int N)
        {
            int i = 0;
            int aux = 0, F0 = 0, F1 = 1; 

            while (i < N)
            {
                System.Console.WriteLine("{0}", F0);
                aux = F0 + F1;
                F0 = F1;
                F1 = aux;
                i++;
            }
        }
    }
}
