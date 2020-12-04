
namespace Zoo
{
    class Zebra : Animal, IHerbivor
    {

        public void Start()
        {
            name = "Marty";


        }

        public void EatLeaves()
        {
            Speak("munch munch zank yee bra");
        }

        public override void SayHello()
        {
            base.SayHello();
            text.text = "zebra zebra XD";

        }

    }
}
