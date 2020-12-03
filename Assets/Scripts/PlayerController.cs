using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float forceJump = 10f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnLeftButtonDown()
    {
        rb.velocity = new Vector2(-1f * speed, rb.velocity.y);
    }

    public void OnRightButtonDown()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    public void OnButtonUp()
    {
        rb.velocity = new Vector2(0f, rb.velocity.y);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            if (collision.relativeVelocity.y >= 0)
            {
                rb.velocity = Vector2.up * forceJump;
            }
        }
        if (collision.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("Defeat");
        }

    }

}
