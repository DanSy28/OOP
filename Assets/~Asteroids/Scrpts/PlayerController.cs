using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class PlayerController : MonoBehaviour
    {
        public Moving movement;
       

        // Update is called once per frame
        void Update()
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

    }
}
