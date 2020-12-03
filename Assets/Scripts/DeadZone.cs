using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            collision.gameObject.transform.position = new Vector2(Random.Range(-1.7f, 1.7f), Random.Range(collision.gameObject.transform.position.y + 13f, collision.gameObject.transform.position.y + 15f));
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
