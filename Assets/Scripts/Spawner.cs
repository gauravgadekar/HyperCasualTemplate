using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstacle;
    public Transform[] pos;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacles", 4,4);
    }

    public void SpawnObstacles()
    {
        Instantiate(obstacle, pos[Random.Range(0, pos.Length)].position, Quaternion.identity);
    }

}
