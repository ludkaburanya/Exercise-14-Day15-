namespace z3
{
    class Program
    {
        static void Main()
        {
            Thread thread1 = new Thread(new ThreadStart(FirstThread));
            thread1.Start();
            Thread thread2 = new Thread(new ThreadStart(SecondThread));
            thread2.Start();

            static void FirstThread()
            {
                Console.Write("Введите А:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите N:");
                double n = Convert.ToDouble(Console.ReadLine());
                double sum = 0;

                for (int i = 0; i < a; i++)
                {
                    sum = Math.Pow(a, n);
                    Console.Write(sum);
                    Thread.Sleep(30);
                }
            }
           
            static void SecondThread()
            {
                Console.Write("Введите А:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите N:");
                double n = Convert.ToDouble(Console.ReadLine());
                double sum = 0;

                for (int i = 0; i < a; i++)
                {
                    sum = Math.Pow(a, n); 
                    Console.Write(sum);
                    Thread.Sleep(30);
                }
            }
            
        }

    }
}