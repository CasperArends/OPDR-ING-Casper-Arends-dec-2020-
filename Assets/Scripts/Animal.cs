using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Zoo
    {
    public class Animal : MonoBehaviour
    {
        public string name;
        public string eatsound;
        public GameObject balloon;
        public Text text;
        public bool canTrick;
        
        public IHerbivor herbivor = null;
        public ICarnivor carnivor = null;

        /// <summary>
        /// gets called when SayHello button is pressed
        /// </summary>
        virtual public void SayHello()
        {
            balloon.SetActive(true);
        }

        /// <summary>
        /// When an Animal makes a sound (eats meat/leaves or asks say hello).
        /// </summary>
        /// <param name="sound">Needs a string for the speak text</param>
        virtual public void Speak(string sound)
        {
            balloon.SetActive(true);
            text.text = sound;
        }

        /// <summary>
        /// Gets called when Tricks button is pressed.
        /// </summary>
        virtual public void PerformTrick()
        {
            StartCoroutine(DoTrick());
        }

        /// <summary>
        /// Every frame x rotation transforms by 1.
        /// </summary>
        IEnumerator DoTrick()
        {
            
            for (int i = 0; i < 360; i++)
            {
                transform.localRotation = Quaternion.Euler(i, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            
        }
    }

    public interface IHerbivor
    {
        /// <summary>
        /// Called when button Give leaves is presssed.
        /// </summary>
        void EatLeaves();
    }

    public interface ICarnivor
    {
        /// <summary>
        /// Called when button Give meat is presssed.
        /// </summary>
        void EatMeat();
        
    }

}




