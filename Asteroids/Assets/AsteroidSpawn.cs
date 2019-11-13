using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawn : MonoBehaviour
{
    public GameObject[] asteroidPrefabs;
    public float spawnRate = 1f;
    public float spawnRadius = 5f;

    void Spawn()
    {
        Vector3 rand = Random.insideUnitSphere * spawnRadius;
        rand.z = 0f;
        Vector3 position = transform.position + rand;
        int randIndex = Random.Range(0, asteroidPrefabs.Length);
        GameObject randAsteroid = asteroidPrefabs[randIndex];
        GameObject clone = Instantiate(randAsteroid);
        clone.transform.position = position;
    }

    private void Start()
    {
        InvokeRepeating("Spawn", 0, spawnRate);
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Destroy(gameObject);
    }
}
