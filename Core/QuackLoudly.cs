namespace DesignPatterns.Strategy.Core
{
    public class QuackLoudly : IQuack
    {
        void IQuack.Quack()
        {
            System.Console.WriteLine("I quack loudly!");
        }
    }
}