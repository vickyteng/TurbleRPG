using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject dBox;
    public Text dText;

    public bool dialogIsActive;

    public string[] dialogLines;

    public int currentLine = 0;

    // Start is called before the first frame update
    void Start()
    {
        dialogIsActive = false;
        dBox.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogIsActive && Input.GetKeyDown(KeyCode.Space))
        {
            //dialogIsActive = false;
            //dBox.SetActive(false);
            currentLine++;
        }

        if (currentLine >= dialogLines.Length)
        {
            dialogIsActive = false;
            dBox.SetActive(false);

            currentLine = 0;
        }

        dText.text = dialogLines[currentLine];
    }

    public void ShowDialogue()
    {
        dialogIsActive = true;
        dBox.SetActive(true);
    }
}
