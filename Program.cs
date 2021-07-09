using ExampleApp.ControllerExample;
using ExampleApp.ScopeExamples;
using System;

namespace ExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Scope Examples
            // 1. Static:
            Console.WriteLine($"This is a static bool: {ScopeStatic.boolTest}");

            // 2. Initialization:
            ScopeInit scope = new ScopeInit();
            Console.WriteLine($"This is the bool from initializing: {scope.boolTest}");

            // 3. Instance:
            ScopeInstance instance = ScopeInstance.GetInstance();
            Console.WriteLine($"This is the bool from instance: {instance.boolTest}");
            #endregion

            #region Controller Example
            Lettuce lettuce = new Lettuce();
            Console.WriteLine($"This lettuce is green: {lettuce.isGreen}");
            #endregion
        }
    }
}
