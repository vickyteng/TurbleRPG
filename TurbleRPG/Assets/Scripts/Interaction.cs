using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public bool positiveInteraction;
    public int impact;
    public string[] dialogueLines;

    private DialogueManager dManager;
    private PlayerHealthManager healthManager;

    // Start is called before the first frame update
    void Start()
    {
        dManager = FindObjectOfType<DialogueManager>();
        healthManager = FindObjectOfType<PlayerHealthManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "turble_0" && Input.GetKeyUp(KeyCode.Space))
        {
            if (!dManager.dialogIsActive)
            {
                dManager.dialogLines = dialogueLines;
                dManager.currentLine = 0;
                dManager.ShowDialogue();
            }

            if (positiveInteraction)
            {
                healthManager.HealPlayer(impact);
            }
            else
            {
                healthManager.HurtPlayer(impact);
            }

        }
    }
}
