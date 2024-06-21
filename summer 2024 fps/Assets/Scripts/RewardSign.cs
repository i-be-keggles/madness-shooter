using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardSign : MonoBehaviour
{
    public GameObject player;
    PlayerStatManager playerStats;
    Animator signAnimator;
    // Start is called before the first frame update
    void Start()
    {
        signAnimator = gameObject.GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerStats = player.GetComponent<PlayerStatManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log(playerStats.rerollCount);
        if (playerStats.rerollCount > 0)
        {
            playerStats.rerollCount --;
            //signAnimator.SetTrigger("rerollSign");
            
        }
        

    }
}
