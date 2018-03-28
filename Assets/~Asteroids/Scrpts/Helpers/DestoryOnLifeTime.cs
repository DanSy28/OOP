using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class DestoryOnLifeTime : MonoBehaviour
    {

        public float lifeTime = 5f;
        void Start()
        {
            Destroy(gameObject, lifeTime);
        }
       
    }
}
