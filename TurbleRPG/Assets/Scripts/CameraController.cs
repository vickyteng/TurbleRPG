using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class CameraController : MonoBehaviour
{

    public GameObject followTarget;
    public float moveSpeed = 1;
    private float mapWidth;
    private float mapHeight;

    private Vector3 targetPos;
    private static bool cameraExists;
    private Scene currScene;

    // Start is called before the first frame update
    void Start()
    {
       
        currScene = SceneManager.GetActiveScene();
        // Set mapWidth and mapHeight
        SetMapSize();

        // prevents duplicates of camera
        if (!cameraExists)
        {
            cameraExists = true;
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
        currScene = SceneManager.GetActiveScene();

        if (currScene.name == "Outdoors") {
            targetPos = new Vector3(followTarget.transform.position.x, followTarget.transform.position.y,
                transform.position.z);
            transform.position = Vector3.Lerp(transform.position, targetPos, moveSpeed * Time.deltaTime);
        }
        else
        {
            // Set mapWidth and mapHeight
            SetMapSize();

            float x = mapWidth / 2;
            float y = 0 - (mapHeight / 2);
            targetPos = new Vector3(x, y, transform.position.z);
            transform.position = targetPos;
        }
    }

    void SetMapSize()
    {
        if (currScene.name == "Main" || currScene.name == "Friend_Bedroom")
        {
            mapWidth = 13;
            mapHeight = 11;
        }
        else if (currScene.name == "Hallway")
        {
            mapWidth = 19;
            mapHeight = 9;
        }
        else if (currScene.name == "Bathroom")
        {
            mapWidth = 11;
            mapHeight = 9;
        }
        else if (currScene.name == "Classroom")
        {
            mapWidth = 17;
            mapHeight = 13;
        }
        else if (currScene.name == "DiningHall")
        {
            mapWidth = 15;
            mapHeight = 10;
        }
        else if (currScene.name == "Gym")
        {
            mapWidth = 11;
            mapHeight = 10;
        } else if (currScene.name == "HealthCenter")
        {
            mapWidth = 9;
            mapHeight = 9;
        }
    } 
}
