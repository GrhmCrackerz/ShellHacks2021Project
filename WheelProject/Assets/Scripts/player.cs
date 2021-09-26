using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public int maxHealth = 10;
    public int currentHealth;

    public HealthBar2 healthBar2;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar2.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar2.SetHealth(currentHealth);
    }
}
