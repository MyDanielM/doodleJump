using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerate : MonoBehaviour
{
    public GameObject platform;
    private Vector3 SpawnPosition = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        SpawnPosition.y = 0;
        for ( int i =0; i<10; i++)
        {
            SpawnPosition.x = Random.Range(-1.7f, 1.7f);
            SpawnPosition.y += Random.Range(1.2f, 1.5f);
            Instantiate(platform, SpawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
