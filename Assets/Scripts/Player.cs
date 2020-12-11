using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool isGrounded = false;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(0, 28f);
            FindObjectOfType<AudioManager>().Play("Player-Jump");
        }
    }
    void OnCollisionEnter2D (Collision2D col)
    {
        if(col.gameObject.tag == "Cactus")
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        if (col.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit2D (Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
        void OnCollisionStay2D (Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
