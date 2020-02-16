using System;

namespace StrategyPatternCodeExample
{
    class CompleteAnalysis : IAntivirusStrategy
    {
        public void AnalizeSystem()
        {
            ScanWindowsDirectory();
            ScanUserDocuments();
            ScanMemoryObjects();
        }

        private void ScanMemoryObjects()
        {
            Console.WriteLine("Memory has been scanned.");
        }

        private void ScanUserDocuments()
        {
            Console.WriteLine("User documents have been scanned.");
        }

        private void ScanWindowsDirectory()
        {
            Console.WriteLine("Windows directory has been  scanned.");
        }
    }
}
