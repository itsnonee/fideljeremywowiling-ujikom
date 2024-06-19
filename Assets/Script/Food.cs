using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public float Lifetime = 3f;

    private void Update()
    {
        StartCoroutine(DestroyGameObject());
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Object")
        {
            Destroy(other.gameObject);
        }
    }

    IEnumerator DestroyGameObject()
    {
        yield return new WaitForSeconds(Lifetime);
        Destroy(gameObject);
    }
}
