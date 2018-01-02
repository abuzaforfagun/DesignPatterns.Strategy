namespace DesignPatterns.Strategy.Core
{
    public class CanNotFly : IFly
    {
        void IFly.Fly()
        {
            System.Console.WriteLine("I can not fly! :(");
        }
    }
}