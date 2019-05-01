using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
	public int healthPoints;


	void Start()
    {
        GameObject.FindGameObjectWithTag("Lifetext").GetComponent<Text>().text = "X " + healthPoints;

		GlobalVariables.restartPosition = this.transform.position;
	}

	public void LooseHP(int damage)
    {
		healthPoints=healthPoints-damage;

        GameObject.FindGameObjectWithTag("Lifetext").GetComponent<Text>().text = "X " + healthPoints;

        if (healthPoints > 0) {
			Respawn ();
			Debug.Log("Respawn");
		}
        else
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
	}

    public void GainHP(int lifegain)
    {
        healthPoints = healthPoints + lifegain;

        GameObject.FindGameObjectWithTag("Lifetext").GetComponent<Text>().text = "X " + healthPoints;
        
    }

	public void Respawn(){
		this.gameObject.transform.position=GlobalVariables.restartPosition;
	}

}
