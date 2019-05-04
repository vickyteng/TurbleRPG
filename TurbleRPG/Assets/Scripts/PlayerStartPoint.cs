using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class PlayerStartPoint : MonoBehaviour
{
    private PlayerController player;
    private CameraController cam;
    private Scene currScene;
    private string lastScene;
    private Transform to;

    // Hallway
    public GameObject startFromOutdoors;
    public GameObject startFromFriends;
    public GameObject startFromBathroom;

    // Outdoors
    public GameObject startFromHealthCenter;
    public GameObject startFromGym;
    public GameObject startFromClass;
    public GameObject startFromDiningHall;

    // Start is called before the first frame update
    void Start()
    {
        currScene = SceneManager.GetActiveScene();
        player = FindObjectOfType<PlayerController>();
        cam = FindObjectOfType<CameraController>();
        lastScene = PlayerPrefs.GetString("LastScene", null);

        if (currScene.name == "Hallway" && lastScene != null)
        {
            switch (lastScene)
            {
                case "Bathroom":
                    to = startFromBathroom.transform;

                    player.transform.position = to.position;
                    cam.transform.position = new Vector3(to.position.x, to.position.y, cam.transform.position.z);

                    break;
                case "Outdoors":
                    to = startFromOutdoors.transform;

                    player.transform.position = to.position;
                    cam.transform.position = new Vector3(to.position.x, to.position.y, cam.transform.position.z);

                    break;
                case "Main":
                    player.transform.position = transform.position;
                    cam.transform.position = new Vector3(transform.position.x, transform.position.y, cam.transform.position.z);
                    break;
                default:
                    to = startFromFriends.transform;

                    player.transform.position = to.position;
                    cam.transform.position = new Vector3(to.position.x, to.position.y, cam.transform.position.z);

                    break;
            }
        }
        else if (currScene.name == "Outdoors" && lastScene != null)
        {
            switch (lastScene)
            {
                case "HealthCenter":
                    to = startFromHealthCenter.transform;

                    player.transform.position = to.position;
                    cam.transform.position = new Vector3(to.position.x, to.position.y, cam.transform.position.z);

                    break;
                case "DiningHall":
                    to = startFromDiningHall.transform;

                    player.transform.position = to.position;
                    cam.transform.position = new Vector3(to.position.x, to.position.y, cam.transform.position.z);

                    break;
                case "Gym":
                    to = startFromGym.transform;

                    player.transform.position = to.position;
                    cam.transform.position = new Vector3(transform.position.x, transform.position.y, cam.transform.position.z);

                    break;
                case "Class":
                    to = startFromClass.transform;

                    player.transform.position = to.position;
                    cam.transform.position = new Vector3(to.position.x, to.position.y, cam.transform.position.z);
                    break;
                default:        // from dorm
                    player.transform.position = transform.position;
                    cam.transform.position = new Vector3(transform.position.x, transform.position.y, cam.transform.position.z);

                    break;
            }
        }
        else
        {
            player.transform.position = transform.position;
            cam.transform.position = new Vector3(transform.position.x, transform.position.y, cam.transform.position.z);
        }
      }

    // Update is called once per frame
    void Update()
    {
        
    }
}
