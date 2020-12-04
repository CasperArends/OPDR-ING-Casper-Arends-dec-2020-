
namespace Zoo
{
    class Lion : Animal, ICarnivor
    {

        public void Start()
        {
            name = "Henk";
            canTrick = true;
        }

        public void EatMeat()
        {
            Speak("nom nom thx mate");
                
        }
        
        public override void SayHello()
        {
            base.SayHello();
            text.text = "rrrooooaaarr";

        }
    }
}
