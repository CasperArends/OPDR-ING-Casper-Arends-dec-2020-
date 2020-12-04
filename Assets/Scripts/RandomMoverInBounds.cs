using UnityEngine;

namespace Zoo
{
    public class RandomMoverInBounds : MonoBehaviour
    {
        [SerializeField]
        private int left, right, top, bottum;
        [SerializeField]
        private float speed;

        private Vector3 goal;

        private void Start()
        {
            PickGoal();
        }

        /// <summary>
        /// Moves animals to their goal,
        /// When an animal hits a side it picks a new goal
        /// </summary>
        private void Update()
        {
            Vector3 direction = goal - transform.localPosition;
            transform.Translate(direction.normalized * speed * Time.deltaTime);
            if (direction.magnitude < 5)
                PickGoal();
        }

        /// <summary>
        /// Gets a random new goal
        /// </summary>
        private void PickGoal()
        {
            goal = new Vector2(
                Random.Range(left, right),
                Random.Range(bottum, top));
        }
    }
}