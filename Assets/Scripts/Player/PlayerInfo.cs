using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] public int maxHealth;
    [SerializeField] [Range(0.0F, 100.0F)] int currentHealth;
    public UpdateHP healthBar;

    // Start is called before the first frame update
    void Start()
    {
        healthBar.setMaxHealth(maxHealth);
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.setHealth(currentHealth);
    }

    public void takeDamage(int damage)
    {
        Debug.Log("damage taken");
        currentHealth -= damage;
    }
}
