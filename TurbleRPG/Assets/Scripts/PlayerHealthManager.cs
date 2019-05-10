using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    public int playerMaxHealth = 100;
    public int playerCurrHealth;

    public Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        playerCurrHealth = (playerMaxHealth * 3) / 4;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = $"{playerCurrHealth}/100";

        // Make gameobject canvas show up that player died, press r to restart
        if (playerCurrHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }

    public void HurtPlayer(int damage)
    {
        playerCurrHealth -= damage;
        healthText.text = $"{playerCurrHealth}/100";
    }

    public void HealPlayer(int heal)
    {
        if (playerCurrHealth + heal <= 100) {
            playerCurrHealth += heal;
        }
        healthText.text = $"{playerCurrHealth}/100";
    }
}
