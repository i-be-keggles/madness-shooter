using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : ItemPickup
{


    // Start is called before the first frame update
    void Start()
    {
        OnStart();
        itemName = "Coin";
        itemCoinGain = 1;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
