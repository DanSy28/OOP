﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class Moving : MonoBehaviour
    {

        public float acceleration = 5f;
        public float rotationSpeed = 5f;
        public float maxVelocity = 3f;

        private Rigidbody2D rigid;

        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            LimitVelocity();
        }
        void LimitVelocity()
        {
            // Made a copy of rigid.velocity
            Vector3 vel = rigid.velocity;
            // Checking copy to see if it's too high
            if (vel.magnitude > maxVelocity)
            {
                vel = vel.normalized * maxVelocity;
            }
            rigid.velocity = vel;
        }

        public void Accelerate(Vector3 direction)
        {
            rigid.AddForce(direction * acceleration);
        }
        public void Rotate(float angleOffset)
        {
            rigid.rotation -= angleOffset * rotationSpeed *  Time.deltaTime;
        }

        public void RotationLeft()
        {
            rigid.rotation += rotationSpeed * Time.deltaTime;
        }
        public void RotationRight()
        {
            rigid.rotation -= rotationSpeed * Time.deltaTime;
        }
    }
}
