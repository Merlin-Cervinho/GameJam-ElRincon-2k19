
using UnityEngine;

public class Coin : MonoBehaviour {
    public int rotationSpeed;
	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector2.up*rotationSpeed*Time.deltaTime*50);
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name=="pig")
        {

            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<CircleCollider2D>().enabled = false;
            collision.collider.GetComponent<PlayerController>().remainingCoins -= 1;
            Debug.Log(collision.collider.GetComponent<PlayerController>().remainingCoins);

        }
    }
}
