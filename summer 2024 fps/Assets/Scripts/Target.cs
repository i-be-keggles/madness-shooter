using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;



    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnMouseDown()
    {
        currentHealth--;
        Debug.Log("hit " + currentHealth);
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
            
    }
}
