using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    public int maxHealth = 100;
    public int curHealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        curHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        curHealth -= amount;

        if (curHealth < 0) Die();
    }

    public void Die()
    {
        Destroy(gameObject);
        print("Died");
    }
}
