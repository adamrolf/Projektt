using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GroundSpawn : MonoBehaviour
{




    public GameObject Ground1, Ground2,  Ground3;
    public bool hasGround = true;
    public int score = 0;
    public Text Skore;


    private void Update()
    {
        if (!hasGround)
        {
            SpawnGround();
            hasGround = true;
        }
    }

    public void SpawnGround()
{
        int randomNum = Random.Range(1, 4);
       
        if (randomNum == 1)
        {
            Instantiate(Ground1, new Vector3(transform.position.x + 17, -2.3f, -1.156657f), Quaternion.identity);
            score ++;
            Debug.Log("Skore + 1");

        }

        if (randomNum == 2)
        {
            Instantiate(Ground2, new Vector3(transform.position.x + 13, -3f, -1.156657f), Quaternion.identity);
            score ++;
            Debug.Log("Skore + 1");
        } 
        if (randomNum == 3)
        {
            Instantiate(Ground3, new Vector3(transform.position.x + 15, -3.8f, -1.156657f), Quaternion.identity);
            score ++;
            Debug.Log("Skore + 1");

        }
    Skore.text = "Skore: " + score; 
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("zem"))
        {
            hasGround = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("zem"))
   
        hasGround = false;
    }
};

    
    

