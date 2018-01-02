namespace DesignPatterns.Strategy.Core
{
    public class Duck
    {
        public string Name { get; set; }
        IDisplay display;
        IFly fly;
        IQuack quack;
        
        public Duck(IDisplay display, IFly fly, IQuack quack)
        {
            this.display =display;
            this.fly=fly;
            this.quack=quack;
        }
        public void SetDisplay(IDisplay display){
            this.display = display;
        }

        public void SetFly(IFly fly){
            this.fly = fly;
        }

        public void SetQuack(IQuack quack){
            this.quack = quack;
        }

        public void Quack(){
            quack.Quack();
        }
        public void Fly(){
            fly.Fly();
        }
        public void Display(){
            display.Display();
        }
    }
}