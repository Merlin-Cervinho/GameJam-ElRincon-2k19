using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spike : MonoBehaviour {

    public int damage;

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.name == "pig")
        {
            other.collider.GetComponent<PlayerController>().LooseCoins(damage);
        }
    }
}
