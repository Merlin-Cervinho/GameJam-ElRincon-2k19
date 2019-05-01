
using UnityEngine;

public class saw : MonoBehaviour {
    public int damage;
    // Use this for initialization
    public int rotationSpeed;

	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Rotate(Vector3.back*rotationSpeed*Time.deltaTime);
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.name == "pig")
        {
            other.collider.GetComponent<PlayerController>().LooseCoins(damage);
        }
    }
}
