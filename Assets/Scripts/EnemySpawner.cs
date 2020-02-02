using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Object;
    
    
    void Start()
    {
        InvokeRepeating("SpawnObject", 2, 1);
    }
    
    void SpawnObject()
    {
        float x = Random.Range(-28, -28.3f);
        float z = Random.Range(131f, 133f);
        Instantiate(Object, new Vector3(x, 2, z), Quaternion.identity);
    }
}
