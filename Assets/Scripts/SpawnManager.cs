using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(0, 0, 30);
    private float randomY;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 0.5f, 5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnObstacle()
    {
        randomY = Random.Range(-10, 10);
        spawnPos = new Vector3(0, randomY, spawnPos.z + 50f);

        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}


