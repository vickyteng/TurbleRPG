using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DepressionManager : MonoBehaviour
{
    public Image shadow;
    public Text diesText;

    private float opacity;
    private PlayerHealthManager healthManager;
    private DialogueManager dManager;
    private Color c;

    // Start is called before the first frame update
    void Start()
    {
        healthManager = FindObjectOfType<PlayerHealthManager>();
        dManager = FindObjectOfType<DialogueManager>();
        opacity = 1 - ((float)healthManager.playerCurrHealth / 100f);

        c = Color.black;
        c.a = opacity;
        shadow.color = c;

        diesText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (healthManager.playerCurrHealth <= 10 && healthManager.playerCurrHealth > 0)
        {
            opacity = 0.9f;
        }
        else
        {
            opacity = 1 - ((float)healthManager.playerCurrHealth / 100f);
        }

        c.a = opacity;
        shadow.color = c;

        if (healthManager.playerCurrHealth <= 0)
        {
            diesText.text = "Unfortunately, Lance did not want to live another day. Press R to restart Game";
        }

        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("Main");
            RestartGame();
        }
    }

    void RestartGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        diesText.text = "";
        healthManager.playerCurrHealth = 75;

        opacity = 1 - ((float)healthManager.playerCurrHealth / 100f);
        c.a = opacity;
        shadow.color = c;

        dManager.dialogLines = new string[0];

        PlayerPrefs.SetString("LastScene", "");
        PlayerPrefs.Save();
    }
}
