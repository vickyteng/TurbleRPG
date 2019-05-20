using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    private Animator anim;
    public GameObject isUp;
    public GameObject isRight;
    public GameObject isLeft;
    public GameObject player;
    private bool state;
    private Vector2 playerPos;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        state = false;
        playerPos = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //print(transform.position.x);
        print(playerPos);
    }

    void OnTriggerStay2D(Collider2D collision)
    {



        if (collision.gameObject.name == "turble_0" && Input.GetKeyUp(KeyCode.Space))
        {
            player.transform.position = playerPos;
            state = true;
            //print("Here?");
            if (transform.position.x > playerPos.x)
            {
                anim.SetBool("isLeft", state);
            }
            else if (transform.position.x < playerPos.x)
            {
                anim.SetBool("isRight", state);
            }
            else if (transform.position.y < playerPos.y)
            {
                anim.SetBool("isUp", state);
            }
        }
        /*
        else if (gameObject.name == "Left")
        {
            if (collision.gameObject.name == "turble_0" && Input.GetKeyUp(KeyCode.Space))
            {
                state = true;
                anim.SetBool("isLeft", state);
            }
        }
        else if (gameObject.name == "right")
        {
            if (collision.gameObject.name == "turble_0" && Input.GetKeyUp(KeyCode.Space))
            {
                state = true;
                anim.SetBool("isright", state);
            }
        }
        */

    }

    
    void OnTriggerExit2D(Collider2D collison)
    {
        state = false;
        anim.SetBool("isLeft", state);
        anim.SetBool("isUp", state);
        anim.SetBool("isRight", state);
    }
}
