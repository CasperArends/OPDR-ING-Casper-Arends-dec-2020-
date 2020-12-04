

namespace Zoo
{
    class Pig : Animal, ICarnivor, IHerbivor
    {
        public void Start()
        {
            name = "Dora";
            canTrick = true;

        }

        public void EatMeat()
        {
            Speak("nomnomnom oink tnx");
        }

        public void EatLeaves()
        {
            Speak("munch munch oink");
        }

        public override void SayHello()
        {
            base.SayHello();
            text.text = "oink oink";

        }

    }
}
