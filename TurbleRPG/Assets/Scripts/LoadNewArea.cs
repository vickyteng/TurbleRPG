using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class LoadNewArea : MonoBehaviour
{
    public string sceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKey("space") && other.gameObject.name == "turble_0")
        {
            string currentScene = SceneManager.GetActiveScene().name;
            PlayerPrefs.SetString("LastScene", currentScene);
            PlayerPrefs.Save();
            SceneManager.LoadScene(sceneToLoad);

        }
    }
}
