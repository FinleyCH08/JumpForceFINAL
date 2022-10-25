using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
    
{
    private float speed = 10;
    private PlayerController playerControllerScript;
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript =
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
       
        if (playerControllerScript.gameObject == false)
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
            {
                Destroy(gameObject);
            }
        
        }
    }
}
