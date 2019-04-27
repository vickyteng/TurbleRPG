using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If player moves left or right from input, translate in x axis
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate (new Vector3(Input.GetAxisRaw("Horizontal")
                * moveSpeed * Time.deltaTime, 0.0f));
        }

        // If player moves up/down from input, translate in y axis
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0.0f, Input.GetAxisRaw("Vertical")
                * moveSpeed * Time.deltaTime));
        }

    }
}
