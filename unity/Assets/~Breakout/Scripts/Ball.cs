using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Breakout
{
    public class Ball : MonoBehaviour
    {
        public float speed = 5f;
        private Vector3 velocity;
        /*
        GameManager.Instance.AddScore(1);
        */
        public void Fire(Vector3 direction)
        {
            velocity = direction * speed;
        }
        void OnCollisionEnter2D(Collision2D other)
        {
            ContactPoint2D contact = other.contacts[0];
            Vector3 reflect = Vector3.Reflect(velocity, contact.normal);
            velocity = reflect.normalized * velocity.magnitude;
        }
              // Update is called once per frame
        private void Update()
        {
            transform.position += velocity * Time.deltaTime;

        }
    }
}
