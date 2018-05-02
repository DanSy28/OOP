using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class Shooting : MonoBehaviour
    {
        public GameObject bulletPrefab;
        public Transform[] spawnPoint;
        public float bulletSpeed = 5f;


        public void Fire(Vector3 direction)
        {
            for (int i = 0; i <spawnPoint.Length; i++)
            {
                Spawn(direction, spawnPoint[i].position);
            }
                        
        }
        void Spawn(Vector3 direction, Vector3 point)
        {
            GameObject clone = Instantiate(bulletPrefab);
            clone.transform.position = point;
            float angle = Mathf.Atan2(direction.y, direction.x);
            float degrees = Mathf.Rad2Deg;
            clone.transform.rotation = Quaternion.AngleAxis(degrees, Vector3.forward);
            Rigidbody2D rigid = clone.GetComponent<Rigidbody2D>();
            rigid.AddForce(direction * bulletSpeed, ForceMode2D.Impulse);
        }


    }
}
