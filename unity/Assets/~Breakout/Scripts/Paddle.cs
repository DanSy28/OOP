using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Breakout
{
    public class Paddle : MonoBehaviour
    {
        public float movementSpeed = 20f;
        public Ball currentBall;
        public Vector2[] directions = new Vector2[]
        {
            new Vector2(-0.5f, 0.5f),
            new Vector2(0.5f, 0.5f)
        };
        // Use this for initialization
        void Start()
        {
            currentBall = GetComponentInChildren<Ball>();
        }
        void Fire()
        {
            currentBall.transform.SetParent(null);
            Vector3 randomDir = directions[Random.Range(0, directions.Length)];
            currentBall.Fire(randomDir);
        }
       void CheckInput()
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                Fire();
            }
        }
        void Movement()
        {
            float inputH = Input.GetAxis("Horizontal");
            Vector3 force = transform.right * inputH;
            force *= movementSpeed;
            force *= Time.deltaTime;
            transform.position += force;
        }
        void Update()
        {
            CheckInput();
            Movement();
        }
       
    }
}
