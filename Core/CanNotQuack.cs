namespace DesignPatterns.Strategy.Core
{
    public class CanNotQuack : IQuack
    {
        void IQuack.Quack()
        {
            System.Console.WriteLine("I can not quack :(");
        }
    }
}