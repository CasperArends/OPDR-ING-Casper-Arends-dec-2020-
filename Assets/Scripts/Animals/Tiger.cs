
namespace Zoo
{
    class Tiger : Animal, ICarnivor
    {
        public void Start()
        {
            
            name = "Wally";
            canTrick = true;
                       
        }

        public void EatMeat()
        {
            Speak("nom nom nom tnx wabulubudubdub");
        }

        public override void SayHello()
        {
            base.SayHello();
            text.text = "rrraaaaaawwwwr XD";
            
        }


        





    }
}
