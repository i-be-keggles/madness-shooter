using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRaces : MonoBehaviour
{
    public string raceName;
    public int raceNumber;
    public GameObject player;
    PlayerStatManager playerStats;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerStats = player.GetComponent<PlayerStatManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
