using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{

    // Item stat changes

    public GameObject player;
    PlayerStatManager playerStats;

    public string itemName;

    public bool itemAbility = false;

    public float itemRarity;

    public float itemDamageChange;

    // Health
    public int itemHealthGain;
    public float itemHealthMultiplierChange;

    // Movement speed
    public float itemSpdChange;

    // Ammo
    public int itemAmmoGainMultiplier;
    public int itemAmmoChange;

    // Firerate
    public float itemFRateMultiplier;

    //// Wonder meter
    //public float wonderMeterMax;
    //public float wonderMeterGain;

    //// Reroll rounds
    //public int rerollMax;
    //public int rerollCount;

    // Coins
    public int itemCoinGain;
    public int itemCoinGainMultiplier;

    // Jump
    public float itemJumpMultiplier;

    //// Kills
    //public int kills;

    // Start is called before the first frame update
    public void OnStart()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerStats = player.GetComponent<PlayerStatManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            PickupItem();
        }
    }



    void PickupItem()
    {
        if (itemName != "Coin")
        {
            playerStats.playerItems.Add(itemName);
        }
        playerStats.atkMultiplier += itemDamageChange;
        playerStats.coinGainMultiplier += itemCoinGainMultiplier;
        playerStats.coinCount += itemCoinGain * playerStats.coinGainMultiplier;
        playerStats.fRateMultiplier += itemFRateMultiplier;
        playerStats.playerMoveSpdMultiplier += itemSpdChange;
        
        if (!itemAbility)
        {
            gameObject.SetActive(false);
        }
        else
        {
            playerStats.AttachItem();
            gameObject.SetActive(false);
        }
        
       


    }
}
