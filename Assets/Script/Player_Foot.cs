﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Foot : MonoBehaviour
{
    public GameObject player;
    //public bool ground = false;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            
            player.GetComponent<Player>().JumpReset();
        }
    }
}
