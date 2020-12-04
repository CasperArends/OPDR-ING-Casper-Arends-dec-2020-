namespace Zoo
{
    class Hippo : Animal, IHerbivor
    {
        
        public void Start()
        {            
            name = "Elsa";
            
        }


        public void EatLeaves()
        {
            Speak("nomnomnom");
            
        }

        
        public override void SayHello()
        {
            base.SayHello();
            text.text = "splash";
            
        }

    }
    
}
