using UnityEngine;
using UnityEngine.UI;
using Zoo;

namespace Assets.Scripts
{
    
    class ButtonClass : MonoBehaviour
    {
        Spawner spawner;
        public InputField inputField;
        

        private void Start()
        {
            spawner = GetComponent<Spawner>();
        }

        private void TrickButton()
        {
            foreach(Animal animal in spawner.animals)
            {
                if(animal.canTrick == true)
                {
                    animal.PerformTrick();
                }
            }
        }

        

        private void HelloButton()
        {
            foreach(Animal animal in spawner.animals)
            {
                if(inputField.text.ToString() == animal.name)
                {
                    animal.SayHello();
                }
                else if (inputField.text.ToString() == "")
                {
                    animal.SayHello();
                }
                
            }
        }

        private void GiveMeat()
        {
            Debug.Log(spawner.animals.Count);
            foreach (Animal animal in spawner.animals)
            {
                var carnivorius = animal.GetComponent<ICarnivor>();
                //Debug.Log(animal.carnivor + "in meat foreach loop");
                Debug.Log($"carnivorius var: {carnivorius}");
                if(carnivorius != null)
                {
                    carnivorius.EatMeat();
                    Debug.Log("MEAT");
                }
            }
        }

        private void GiveLeaves()
        {
            foreach(Animal animal in spawner.animals)
            {
                var herbivorius = animal.GetComponent<IHerbivor>();
                Debug.Log($"herbivorius var: {herbivorius}");
                if (herbivorius != null)
                {
                    herbivorius.EatLeaves();
                    Debug.Log("DANG KUSH");
                }
            }
        }
    }
}
