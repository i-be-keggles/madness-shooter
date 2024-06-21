using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExaustPipe : ItemPickup
{
    // Start is called before the first frame update
    void Start()
    {
        OnStart();
        itemName = "Exaust Pipe";
        itemRarity = 1.5f;
        itemFRateMultiplier = 0.5f;
        itemSpdChange = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
