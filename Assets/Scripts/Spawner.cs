using System.Collections.Generic;
using UnityEngine;

namespace Zoo
{
    class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject lion, hippo, pig, tiger, zebra, monkey, toucan;
        
        public List <Animal> animals;
        /// <summary>
        /// Instantiates every animal and adds them to the scene.
        /// </summary>
        private void Start()
        {
            Lion henk = Instantiate(lion, transform).GetComponent<Lion>();
            Hippo elsa = Instantiate(hippo, transform).GetComponent<Hippo>();
            Pig dora = Instantiate(pig, transform).GetComponent<Pig>();
            Tiger wally = Instantiate(tiger, transform).GetComponent<Tiger>();
            Zebra marty = Instantiate(zebra, transform).GetComponent<Zebra>();
            Monkey ceaser = Instantiate(monkey, transform).GetComponent<Monkey>();
            Toucan duif = Instantiate(toucan, transform).GetComponent<Toucan>();

            animals.Add(henk);
            animals.Add(elsa);
            animals.Add(dora);
            animals.Add(wally);
            animals.Add(marty);
            animals.Add(ceaser);
            animals.Add(duif);
        }
    }
}
