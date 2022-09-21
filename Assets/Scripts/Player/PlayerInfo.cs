using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] public int maxHealth;
    [SerializeField] [Range(0.0F, 100.0F)] float currentHealth;
    [SerializeField] Slider healthBar;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = currentHealth;
    }
}
