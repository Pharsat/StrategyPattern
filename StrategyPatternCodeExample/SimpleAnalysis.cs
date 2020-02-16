using System;

namespace StrategyPatternCodeExample
{
    class SimpleAnalysis : IAntivirusStrategy
    {
        public void AnalizeSystem()
        {
            ScanWindowsDirectory();
            ScanMemoryObjects();
        }

        private void ScanMemoryObjects()
        {
            Console.WriteLine("Memory has been scanned.");
        }

        private void ScanWindowsDirectory()
        {
            Console.WriteLine("Windows directory has been  scanned.");
        }
    }
}
