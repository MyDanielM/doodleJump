using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerate : MonoBehaviour
{
    public GameObject platform;
    public GameObject enemy;
    public GameObject hole;
    public GameObject prujPlatform;
    public GameObject destroyPlatform;
    private Vector3 SpawnPosition = new Vector3();

    // Start is called before the first frame update
    void Start()
    {
        SpawnPosition.y = 0;
        for ( int i =0; i<20; i++)
        {
            SpawnPosition.x = Random.Range(-1.7f, 1.7f);
            SpawnPosition.y += Random.Range(1.2f, 1.5f);
            switch (i)
            {
                case (3):
                    Instantiate(destroyPlatform, SpawnPosition, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(prujPlatform, SpawnPosition, Quaternion.identity);
                    break;
                case 15:
                    Instantiate(enemy, SpawnPosition, Quaternion.identity);
                    break;
                case 19:
                    Instantiate(hole, SpawnPosition, Quaternion.identity);
                    break;
                default:
                    Instantiate(platform, SpawnPosition, Quaternion.identity);
                    break;
            }               
            
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
