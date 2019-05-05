using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject Pig;
    bool moving;
    public int Speed;
    Vector2 movement;
    public Rigidbody2D rb;
    public int startingCoins;
    int collectedCoins;
    public Text display;

    bool upPressed;
    bool downPressed;
    bool leftPressed;
    bool rightPressed;
    bool up;
    bool down;
    bool left;
    bool right;
    public float valorJuntos;
    public int remainingCoins = 7;

    // Use this for initialization
    void Start ()
    {
        moving = false;
        movement = Vector2.zero;
        upPressed = false;
        downPressed = false;
        leftPressed = false;
        rightPressed = false;
        collectedCoins = startingCoins;
        valorJuntos = 1; // gameObject.GetComponent<CircleCollider2D>().bounds.size.x;
    }

    private void Update()
    {
        if (remainingCoins <= 0)
        {
            Application.LoadLevel("win");
        }
        if (collectedCoins <= 0)
        {
            Application.LoadLevel("lose");
        }
    }

    void FixedUpdate ()
    {
        display.text = "x " + collectedCoins;
        up = false;
        down = false;
        left = false;
        right = false;

        if (!moving)
        {
            up = Input.GetKeyDown(KeyCode.W);
            down = Input.GetKeyDown(KeyCode.S);
            left = Input.GetKeyDown(KeyCode.A);
            right = Input.GetKeyDown(KeyCode.D);

            if (up&!upPressed) {
            movement = (Vector2.up);
            moving = true;
                upPressed = true;
                downPressed = false;
                leftPressed = false;
                rightPressed = false;
            }
            if (down&!downPressed)
            {
                movement = (Vector2.down);
                moving = true;
                upPressed = false;
                downPressed = true;
                leftPressed = false;
                rightPressed = false;
            }
            if (left&!leftPressed)
            {
                movement = (Vector2.left);
                moving = true;
                upPressed = false;
                downPressed = false;
                leftPressed = true;
                rightPressed = false;
            }
            if (right&!rightPressed)
            {
                movement = (Vector2.right);
                moving = true;
                upPressed = false;
                downPressed = false;
                leftPressed = false;
                rightPressed = true;
            }
        }
        rb.velocity = (movement * Speed * Time.deltaTime);
        //Debug.Log(collectedCoins);

        //Debug.Log(moving);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name != "coin")
        {
            if(rightPressed && (Mathf.Abs(Mathf.Abs(collision.transform.position.x) - Mathf.Abs(transform.position.x)) < valorJuntos))
            {
                moving = false;
            }
            if (leftPressed && Mathf.Abs(Mathf.Abs(transform.position.x) - Mathf.Abs(collision.transform.position.x)) < valorJuntos)
            {
                moving = false;
            }
            if (upPressed && Mathf.Abs(Mathf.Abs(collision.transform.position.y)-Mathf.Abs(transform.position.y)) < valorJuntos)
            {
                moving = false;
            }
            if (downPressed && Mathf.Abs(Mathf.Abs(transform.position.y) - Mathf.Abs(collision.transform.position.y)) < valorJuntos)
            {
                moving = false;
            }
        }
        if(collision.collider.name == "coin")
        {
            collectedCoins += 1;
        }
    }

    public void LooseCoins(int damage)
    {
        collectedCoins = collectedCoins - damage;
    }
}
