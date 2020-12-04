
namespace Zoo
{
    class Monkey : Animal , IHerbivor, ICarnivor
    {
        public void Start()
        {
            name = "Caesar";
            canTrick = true;
        }

        public void EatLeaves()
        {
            Speak("Banana?");
        }

        public void EatMeat()
        {
            Speak("aaaah aaah aah chomp");
        }

        public override void SayHello()
        {
            base.SayHello();
            text.text = "You Banana?";

        }

    }
}
