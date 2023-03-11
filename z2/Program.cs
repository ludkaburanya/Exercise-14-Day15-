using System.Threading;
using System.Diagnostics;
namespace z2
{
    class Program
    {
        static void Main()
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            sWatch.Stop();
            Thread thread1 = new Thread(new ThreadStart(FirstThread));
            thread1.Start();
            Thread thread2 = new Thread(new ThreadStart(SecondThread));
            thread2.Start();

            Console.WriteLine("Затраченное время в миллисекундах на выполнение первого потока:"+ sWatch.ElapsedMilliseconds);
            sWatch.Stop();
            static void FirstThread()
            {
                int sum = 0;
                
                for (int i = 1; i < 11; i++)
                {
                    sum += i;
                }
                Console.WriteLine("Сумма от 1 до 10 первого потока:" + sum);
                Thread.Sleep(10);
            }

            Console.WriteLine("Затраченное время в миллисекундах на выполнение второго потока:"+ sWatch.ElapsedMilliseconds.ToString());
            sWatch.Stop();
            static void SecondThread()
            {
                int sum = 0;
          
                for (int i = 1; i < 11; i++)
                {
                    sum += i;
                }
                Console.WriteLine(new string('-', 50));
                Console.WriteLine("Сумма от 1 до 10 второго потока: " + sum);
                Thread.Sleep(10);
            }
        }
    }
}