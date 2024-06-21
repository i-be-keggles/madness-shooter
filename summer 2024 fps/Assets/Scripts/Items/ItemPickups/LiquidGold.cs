using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiquidGold : ItemPickup
{
    // Start is called before the first frame update
    void Start()
    {
        OnStart();
        itemName = "LiquidGold";
        itemRarity = 1.5f;
        itemAbility = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
