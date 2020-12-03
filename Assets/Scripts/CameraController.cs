using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform doodle;
    public Transform toCam;
    public float speed = 15f;

    private void FixedUpdate()
    {
        if (doodle.position.y> transform.position.y)
        {
            toCam.position = new Vector3(transform.position.x, doodle.position.y, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, toCam.position, Time.deltaTime * speed);
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
