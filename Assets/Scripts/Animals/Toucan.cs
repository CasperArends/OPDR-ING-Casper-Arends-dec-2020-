
namespace Zoo
{
    class Toucan : Animal, IHerbivor
    {
        public void Start()
        {
            name = "Duif";
            

        }

        public void EatLeaves()
        {
            eatsound = "nibble nibble";
            Speak(eatsound);
        }

        public override void SayHello()
        {
            base.SayHello();
            text.text = "Ik ben geen duif";

        }

    }
}
