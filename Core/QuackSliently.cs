namespace DesignPatterns.Strategy.Core
{
    public class QuackSliently : IQuack
    {
        void IQuack.Quack()
        {
            System.Console.WriteLine("I quack sliently!");
        }
    }
}