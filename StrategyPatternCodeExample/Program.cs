using System;

namespace StrategyPatternCodeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new AntivirusContext();

            Console.WriteLine("Press 1 for complete execution or 2 for simple execution.");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    context.SetStrategy(new CompleteAnalysis());
                    context.ExecuteScan();
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    context.SetStrategy(new SimpleAnalysis());
                    context.ExecuteScan();
                    break;

                default:
                    context.SetStrategy(new SimpleAnalysis());
                    context.ExecuteScan();
                    break;
            }
            Console.ReadLine();
        }
    }
}
