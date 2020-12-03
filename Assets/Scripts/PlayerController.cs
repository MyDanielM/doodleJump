using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class PlayerController : MonoBehaviour
{
    public GameObject destroyPlatform;
    public int score = 0;
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
                score += 5;
            }
            
        }
        if (collision.gameObject.tag == "prujPlatform")
        {
            if (collision.relativeVelocity.y >= 0)
            {
                rb.velocity = Vector2.up * forceJump*2;
            }
            score += 20;
        }
        if (collision.gameObject.tag == "destroyPlatform")
        {

            Destroy(collision.gameObject);
            Instantiate(destroyPlatform, 
                        new Vector3(Random.Range(-1.7f, 1.7f), Random.Range(collision.gameObject.transform.position.y + 13f, collision.gameObject.transform.position.y + 15f), 0),
                        Quaternion.identity);
        }
        if (collision.gameObject.tag == "Enemy")
        {
            scoreHolder.Score = score;
            SceneManager.LoadScene("Defeat");
        }

    }

}
