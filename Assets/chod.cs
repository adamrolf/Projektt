using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chod : MonoBehaviour
{
   
    public Rigidbody2D Rigidbody;
    public Transform Feet;
    public Vector3 rychlost;
    public float akcelerace;
    public int pozice;
   
   

    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (transform.position.y < -9)
        {
            Die();
        }
    

        float akcelerace = 1;
            if (akcelerace < 2)
            {
                akcelerace += akcelerace * 1.09f;
            }
        
        
        Vector2 pos = new Vector3(transform.position.x, transform.position.y);
        float frametime = Time.deltaTime;
      


        float meterspersecond = 0.07f;
        float travelled = frametime = meterspersecond;
        pos.x +=travelled;
            
            
        if (Rigidbody.velocity.y == 0)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                Vector2 force = new Vector2(0, 250);
                Rigidbody.AddForce(force);
            }
        }
      transform.position = pos;
      




    }
    void Die()
    {
        
        gameObject.SetActive(false);
         Debug.Log("GameOver");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}



