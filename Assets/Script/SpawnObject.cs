using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float minZ;
    public float maxZ;

    public GameObject spawnObjectContainer;
    public GameObject cowPrefab;
    public float speedObject = 10f;
    public float spawnDistance;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            float randomX = Random.Range(minX, maxX);
            float randomY = Random.Range(minY, maxY);
            float randomZ = Random.Range(minZ, maxZ);
            Vector3 randomPosition = new Vector3(randomX, randomY, randomZ);
            Instantiate(cowPrefab, randomPosition, Quaternion.identity);
        }

    }

    public void SpawnAndMoveObject()
    {
        Vector3 spawnPosition = spawnObjectContainer.transform.position + -transform.forward * spawnDistance;
        // GameObject spawnedObject = Instantiate(foodPrefab, spawnPosition, transform.rotation);
        GameObject spawnedObject = Instantiate(cowPrefab, spawnObjectContainer.transform.position, transform.rotation);

        Rigidbody objectRigidbody = spawnedObject.GetComponent<Rigidbody>();
        if (!objectRigidbody)
        {
            objectRigidbody = spawnedObject.AddComponent<Rigidbody>();
        }

        objectRigidbody.velocity = transform.forward * speedObject;

    }
}
