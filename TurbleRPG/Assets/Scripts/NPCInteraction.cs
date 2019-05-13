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

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        state = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D collision)
    {

        print(transform.position.x);
        print(player.transform.position.x);

        if (collision.gameObject.name == "turble_0" && Input.GetKeyUp(KeyCode.Space))
        {
            state = true;
            //print("Here?");
            if (transform.position.x > player.transform.position.x)
            {
                anim.SetBool("isLeft", state);
            }
            if (transform.position.x < player.transform.position.x)
            {
                anim.SetBool("isRight", state);
            }
            if (transform.position.y < player.transform.position.y)
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
