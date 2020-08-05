namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Olá Mundo!");

            //  System.Console.WriteLine("{0}", Fibonacci(4));

            //  Fibonacci2(11);

            Ordernacao();

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

        public static void Ordernacao()
        {
            int[] vet =  {100,87,50,5,1};

            int[] vet2 = vet;

            int aux2;

            for (int i = 0; i < vet.Length; i++)
            {
                for (int j = 0; j < vet2.Length-1; j++)
                {
                    if(vet2[j] > vet2[j+1])
                    {
                        aux2 = vet2[j + 1];
                        vet2[j + 1] = vet2[j];
                        vet2[j] = aux2;
                    }
                }

            }

            for (int i = 0; i < vet2.Length; i++)
            {
                System.Console.WriteLine("{0}", vet2[i]);
            }
            
        }
    }
}
