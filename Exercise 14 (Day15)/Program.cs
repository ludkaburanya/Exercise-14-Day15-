namespace z1
{
    class Program
    {
        static void Main()
        {
            Thread thread1 = new Thread(new ThreadStart(FirstThread));
            thread1.Start();
            Thread thread2 = new Thread(new ThreadStart(SecondThread));
            thread2.Start();
            Thread thread3 = new Thread(new ThreadStart(ThirdThread));
            thread3.Start();

            static void FirstThread()
            {
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine($"Главный поток: {i}");
                    Thread.Sleep(300);
                }
            }
            Console.WriteLine($"{thread1.Priority}");

            static void SecondThread()
            {
                for (int i = 10; i < 20; i++)
                {
                    Console.WriteLine($"Второй поток: {i}");
                    Thread.Sleep(400);
                }
            }
            Console.WriteLine($"{thread2.Priority}");

            static void ThirdThread()
            {
                for (int i = 20; i < 30; i++)
                {
                    Console.WriteLine($"Третий поток: {i}");
                    Thread.Sleep(500);
                }
            }
            Console.WriteLine($"{thread3.Priority}");
        }

    }
}