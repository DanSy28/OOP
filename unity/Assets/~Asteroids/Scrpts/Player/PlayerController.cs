using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class PlayerController : MonoBehaviour
    {
        public Moving movement;
        public Shooting shoot;
        #region Unity Functions
        // Update is called once per frame
        void Update()
        {
            Shoot();
            Movement();
        }

        #endregion
        #region Custom Function
        void Shoot()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                shoot.Fire(transform.up);
            }
        }

        void Movement()
        {
            float inputV = Input.GetAxis("Vertical");
            float inputH = Input.GetAxis("Horizontal");
            // Check if up arrow is pressed
            if (inputV > 0)
            {
                // Accelerate player
                movement.Accelerate(transform.up);
            }
            // Accelerate player
            //movement.Rotate(inputH);
            if (inputH > 0)
            {
                // If right arrow is pressed
                // Rotate right
                movement.RotationRight();
            }
            if (inputH < 0)
            {
                // If left arrow is pressed
                // Rotate left
                movement.RotationLeft();
            }

        }

        #endregion
    }
}
