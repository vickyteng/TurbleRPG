﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCLeftInteraction : MonoBehaviour
{
    public Animator anim;
    public GameObject player;
    private bool state;
    private Vector2 playerPos;

    // Start is called before the first frame update
    void Start()
    {
        state = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "turble_0" && Input.GetKeyUp(KeyCode.Space))
        {
            state = true;

            anim.SetBool("isLeft", state);
        }
    }

    void OnTriggerExit2D(Collider2D collison)
    {
        state = false;
        anim.SetBool("isLeft", state);
    }
}
