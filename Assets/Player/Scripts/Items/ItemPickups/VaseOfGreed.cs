using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseOfGreed : ItemPickup
{
    // Start is called before the first frame update
    void Start()
    {
        OnStart();
        itemName = "Vase of Greed";
        itemRarity = 2f;
        itemCoinGainMultiplier = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
