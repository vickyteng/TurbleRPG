using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCLeftInteraction : MonoBehaviour
{

    public Animator anim;
    public GameObject isUp;
    public GameObject isright;
    public GameObject isLeft;
    private bool state;

    // Start is called before the first frame update
    void Start()
    {
        //anim = GetComponent<Animator>();
        state = false;
    }

    // Update is called once per frame
    void Update()
    {
        //print(state);
        //print(gameObject.name);
        //print(gameObject);
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        
        //print(collision);
        if (false)
        {
            if (collision.gameObject.name == "turble_0" && Input.GetKeyUp(KeyCode.Space))
            {
                state = true;
                anim.SetBool("isUp", state);
            }
        } else if (gameObject.name == "Left")
        {
            if (collision.gameObject.name == "turble_0" && Input.GetKeyUp(KeyCode.Space))
            {
                state = true;
                anim.SetBool("isLeft", state);
            }
        } else if (gameObject.name == "right")
        {
            if (collision.gameObject.name == "turble_0" && Input.GetKeyUp(KeyCode.Space))
            {
                state = true;
                anim.SetBool("isright", state);
            }
        }
        
    }

    void OnTriggerExit2D(Collider2D collison)
    {
        state = false;
        anim.SetBool("isLeft", state);
        anim.SetBool("isUp", state);
        anim.SetBool("isright", state);
    }
    }
