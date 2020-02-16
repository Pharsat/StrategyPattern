using System;

namespace StrategyPatternAbstractImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start context with default, optional.
            var context = new Context(new ConcreteStrategyA());

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();

            Console.ReadLine();
        }
    }
}
