using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Depression : MonoBehaviour
{
    private static bool depressionExists;

    // Start is called before the first frame update
    void Start()
    {
        if (!depressionExists)
        {
            depressionExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
