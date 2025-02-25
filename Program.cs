using MultiThreadApp.Interfaces;
using MultiThreadApp.Strategies;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace MultiThreadApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IGenerator generator = new ArrayGenerator();
            Context context = new Context();
            Stopwatch timer = new Stopwatch();
            int[] array = generator.GenerateArray(100000, 0, 100);
            CalculateResults(context, timer, array);
            array = generator.GenerateArray(1000000, 0, 100);
            CalculateResults(context, timer, array);
            array = generator.GenerateArray(10000000, 0, 100);
            CalculateResults(context, timer, array);
            Console.ReadKey();
        }

        static void CalculateResults(Context context, Stopwatch timer, int[] array)
        {
            Console.WriteLine($"Длина массива: {array.Length}");

            context.SetStrategy(new StandartStrategy());
            timer.Start();
            long sum1 = context.Execute(array);
            Console.WriteLine($"Обычное вычисление суммы = {sum1}. Выполнено за: {timer.ElapsedMilliseconds}");

            context.SetStrategy(new ParallelStrategy());
            timer.Restart();
            long sum2 = context.Execute(array);
            Console.WriteLine($"Вычисление суммы с помощью Thread = {sum2}. Выполнено за: {timer.ElapsedMilliseconds}");

            context.SetStrategy(new LINQStrategy());
            timer.Restart();
            long sum3 = context.Execute(array);
            timer.Stop();
            Console.WriteLine($"Вычисление суммы с помощью PLINQ = {sum3}. Выполнено за: {timer.ElapsedMilliseconds}");
        }
    }
}
