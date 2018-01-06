using System;
using DesignPatterns.Strategy.Core;

namespace DesignPatterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets work with ideal duck");
            Duck idealDuck = new Duck(new RealLook(), new FlySmothly(), new QuackLoudly());
            idealDuck.Display();
            idealDuck.Fly();
            idealDuck.Quack();

            System.Console.WriteLine("When duck is sick :(");
            idealDuck.SetFly(new FlyHardly());
            idealDuck.SetQuack(new QuackSliently());
            idealDuck.Fly();
            idealDuck.Quack();
            Console.Read();
        }
    }
}
