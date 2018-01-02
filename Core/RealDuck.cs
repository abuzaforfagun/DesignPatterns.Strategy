namespace DesignPatterns.Strategy.Core
{
    public class RealDuck : IDisplay
    {
        void IDisplay.Display()
        {
            System.Console.WriteLine("I am the real duck :)");
        }
    }
}