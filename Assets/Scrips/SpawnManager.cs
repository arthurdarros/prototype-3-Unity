using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("Spawn Parameters")]
    [SerializeField] private GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3 (25, 0, 0);

    [Header("Intervals Parameters")]
    [SerializeField]private float startDelay = 2;
    [SerializeField]private float repeatRate = 2;


    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
