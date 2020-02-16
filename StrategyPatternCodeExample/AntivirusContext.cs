using System;

namespace StrategyPatternCodeExample
{
    class AntivirusContext
    {
        private IAntivirusStrategy _antivirusStrategy;

        public AntivirusContext()
        { }

        public AntivirusContext(IAntivirusStrategy strategy)
        {
            _antivirusStrategy = strategy;
        }

        public void SetStrategy(IAntivirusStrategy strategy)
        {
            _antivirusStrategy = strategy;
        }

        public void ExecuteScan()
        {
            Console.WriteLine();

            Console.WriteLine("Antivirus execution started.");

            _antivirusStrategy.AnalizeSystem();

            Console.WriteLine("Antivirus execution complete.");
        }
    }
}
