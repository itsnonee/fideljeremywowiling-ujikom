using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public GameObject spawnFoodContainer;
    public Rigidbody food;
    public GameObject foodPrefab;
    public float speedFood = 10f;
    public float spawnDistance;


    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Panggil Object");
            SpawnAndMoveObject();
        }
    }

    public void SpawnAndMoveObject()
    {
        Vector3 spawnPosition = spawnFoodContainer.transform.position + transform.forward * spawnDistance;
        GameObject spawnedObject = Instantiate(foodPrefab, spawnFoodContainer.transform.position, transform.rotation);

        Rigidbody objectRigidbody = spawnedObject.GetComponent<Rigidbody>();
        if (!objectRigidbody)
        {
            objectRigidbody = spawnedObject.AddComponent<Rigidbody>();
        }

        objectRigidbody.velocity = transform.forward * speedFood;

    }
}
