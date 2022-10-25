using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repatRate = 2;
    private PlayerController playerControllerscript;
    
    // Start is called before the first frame update
    void Start()
    {
        playerControllerscript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repatRate);
       

    }
    void SpawnObstacle()
    {
        if (playerControllerscript.gameOver == false)

        { Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation); }
        else return;

        // Update is called once per frame
        void Update()
        {

        }
    }
}
