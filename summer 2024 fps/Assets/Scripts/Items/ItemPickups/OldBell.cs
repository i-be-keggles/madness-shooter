using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldBell : ItemPickup
{
    // Start is called before the first frame update
    void Start()
    {
        OnStart();
        itemName = "OldBell";
        itemRarity = 1.2f;
        itemAbility = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

}
