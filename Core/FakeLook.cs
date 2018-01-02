namespace DesignPatterns.Strategy.Core
{
    public class FakeLook : IDisplay
    {
        void IDisplay.Display()
        {
            System.Console.WriteLine("I am nothing but a doll!");
        }
    }
}