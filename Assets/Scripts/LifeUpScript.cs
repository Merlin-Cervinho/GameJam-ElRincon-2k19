using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeUpScript : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.GetComponent<PlayerHealth>().GainHP(1);
            Destroy(gameObject);
        }
    }
}
