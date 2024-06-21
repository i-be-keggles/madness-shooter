using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatManager : MonoBehaviour/*StarterAssets.FirstPersonController*/
{
    // Character build
    public string charName;
    public int charRace;
    public string charDesire;

    //StarterAssets.FirstPersonController fpsController;

    // Player items
    public List<string> playerItems = new List<string>();
    public GameObject[] playerWeapons;
    public GameObject playerAbilityItem;
    ItemPickup itemScript;

    // Stats that matter
    // Attack damage
    public float baseAtkDamage;
    public float atkMultiplier;

    // Health
    public int maxHealth;
    public float healthMultiplier;

    // Player movement speed
    public float basePlayerMoveSpd;
    public float playerMoveSpdMultiplier;

    // Ammo
    public int ammoCount;

    // Firerate
    public float baseFRate;
    public float fRateMultiplier;

    // Wonder meter
    public float wonderMeterMax;
    public float wonderMeterGain;

    // Reroll rounds
    public int rerollMax;
    public int rerollCount;

    // Coins
    public int coinCount;
    public int coinGainMultiplier;

    // Jump
    public float baseJumpForce;
    public float jumpMultiplier;

    // Kills
    public int kills;



    // Start is called before the first frame update
    void Start()
    {
        rerollCount = rerollMax;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void AttachItem()
    {
        playerAbilityItem = GameObject.FindGameObjectWithTag("AbilityItem");
        //itemScript = playerAbilityItem.GetComponent<ItemPickup>();

    }

    public void UseAbility()
    {

    }
}
