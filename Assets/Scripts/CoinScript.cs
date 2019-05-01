using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GlobalVariables.currentCoins += 1;
            Debug.Log("Monedas conseguidas: " + GlobalVariables.currentCoins);

            GameObject.FindGameObjectWithTag("CoinText").GetComponent<Text>().text = "X " + GlobalVariables.currentCoins;

            Destroy(this.gameObject);
        }
    }
}
