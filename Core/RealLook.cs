namespace DesignPatterns.Strategy.Core
{
    public class RealLook : IDisplay
    {
        void IDisplay.Display()
        {
            System.Console.WriteLine("I am the real duck :)");
        }
    }
}