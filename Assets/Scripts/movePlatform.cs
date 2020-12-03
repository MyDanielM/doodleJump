using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlatform : MonoBehaviour
{
    public GameObject currentPlatform;
    private Rigidbody2D rb;
    float currentX;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentX = currentPlatform.transform.position.x;
    }

    // Update is called once per frame
    void FixUpdate()
    {
        if(currentX<-1.99)
            rb.velocity = new Vector2(2f, rb.velocity.y);
        if(currentX>1.99)
            rb.velocity = new Vector2(-2f, rb.velocity.y);
    }
}
