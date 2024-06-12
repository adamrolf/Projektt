using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sledovac : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x + offset.x, transform.position.y, transform.position.z);
        
    }
}
