namespace DesignPatterns.Strategy.Core
{
    public class FlyHardly : IFly
    {
        void IFly.Fly()
        {
            System.Console.WriteLine("I am able to fly but it seems harder to me!");
        }
    }
}