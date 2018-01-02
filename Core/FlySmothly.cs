namespace DesignPatterns.Strategy.Core
{
    public class FlySmothly : IFly
    {
        void IFly.Fly()
        {
            System.Console.WriteLine("Flying smothly");
        }
    }
}