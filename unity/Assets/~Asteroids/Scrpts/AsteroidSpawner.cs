using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids
{
    public class AsteroidSpawner : MonoBehaviour
    {
        public GameObject[] prefabs;
        public float spawnRate = 1f;
        public float minSpeed = 1f;
        public float maxSpeed = 5f;
        

        private float spawnTimer = 0f;

        private Bounds camBounds;
        private float camWidth;
        private float camHeight;

        public void Spawn(GameObject asteroidsPrefabs)
        {

        }

        public float seperation = 5f;
        private Rigidbody rigid;

        void OnTriggerENTER2D(Collider2D col)
        {
            if(col.name.Contains("Player"))
            {
                Vector2 direction = transform.position - col.transform.position;
                rigid.AddForce(direction.normalized * seperation);
            }
        }

        // Use this for initialization
        void Start()
        {
            Camera cam = Camera.main;
            camHeight = 2f * cam.orthographicSize;
            camWidth = camHeight * cam.aspect;
            camBounds = new Bounds(cam.transform.position, new Vector2(camWidth, camHeight));
        }

        // Update is called once per frame
        void Update()
        {
            spawnTimer += Time.deltaTime;
            if(spawnTimer > spawnRate )
            {
                Spawn();
                spawnTimer = 0f;
            }            
        }

        void Spawn()
        {
            Vector3 postion = Vector3.zero;
            float halfWidth = camWidth * 2f;
            float halfHeight = camHeight * 2f;

            if (Random.Range(0, 2) > 0)
            {
                postion.x = Random.Range(-halfWidth, halfWidth);

                if (Random.Range(0, 2) > 0)
                {
                    postion.y = halfHeight;
                }
                else
                {
                    postion.y = -halfHeight;
                }
            }
            else
            {
                postion.x = Random.Range(-halfWidth, halfWidth);

                if (Random.Range(0, 2) > 0)
                {
                    postion.x = halfWidth;
                }
                else
                {
                    postion.x = -halfWidth;
                }

                SpawnAtPosition(postion);
            }
        }
        public void SpawnAtPosition(Vector3 position)
        {
            int randIndex = Random.Range(0, prefabs.Length);
            GameObject asteroid = Instantiate(prefabs[randIndex], transform.position, transform.rotation);
            asteroid.transform.position = position;

            Rigidbody2D rigid = asteroid.GetComponent<Rigidbody2D>();
            float randomSpeed = Random.Range(minSpeed, maxSpeed);
            Vector2 randomDir = Random.onUnitSphere;
            rigid.AddForce(randomDir * randomSpeed, ForceMode2D.Impulse);

        }

    }
}
