using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portada : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Iniciar()
	{
		Application.LoadLevel ("scene1");
	}

	public void Salir()
	{
		Application.Quit();
	}

	public void Credits()
	{
		Application.LoadLevel ("credits");
	}

	public void Win()
	{
		Application.LoadLevel ("Portada");
	}

	public void Lose()
	{
		Application.LoadLevel ("Portada");
	}

	public void Repeat()
	{
		Application.LoadLevel ("scene1");
	}
}
