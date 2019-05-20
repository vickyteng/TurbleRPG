using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthManager : MonoBehaviour
{
    public int playerMaxHealth = 100;
    public int playerCurrHealth;

    public Text healthText;

    float currTime;
    int lastDidSomething;
    int currSeconds;

    // Start is called before the first frame update
    void Start()
    {
        currTime = Time.deltaTime;
        playerCurrHealth = (playerMaxHealth * 3) / 4;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = $"{playerCurrHealth}/100";

        // Make gameobject canvas show up that player died, press r to restart
        if (playerCurrHealth <= 0)
        {
            //gameObject.SetActive(false);
        }

        currTime += Time.deltaTime;
        currSeconds = (int)currTime % 60;

        // If idle for more than 5 seconds, decrease health by 1
        if (lastDidSomething + 5 < currSeconds)
        {
            playerCurrHealth -= 1;
            lastDidSomething = currSeconds;
        }

    }

    public void HurtPlayer(int damage)
    {
        playerCurrHealth -= damage;
        healthText.text = $"{playerCurrHealth}/100";

        currSeconds = (int)currTime % 60;
        lastDidSomething = currSeconds;
    }

    public void HealPlayer(int heal)
    {
        if (playerCurrHealth + heal >= 100) {
            playerCurrHealth = 100;
        }
        else
        {
            playerCurrHealth += heal;
        }
        healthText.text = $"{playerCurrHealth}/100";

        currSeconds = (int)currTime % 60;
        lastDidSomething = currSeconds;
    }
}
