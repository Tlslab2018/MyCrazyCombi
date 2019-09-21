using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    public float delay = 1f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        int x = Random.Range(0, 9);
        if (x > 2)
            Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
