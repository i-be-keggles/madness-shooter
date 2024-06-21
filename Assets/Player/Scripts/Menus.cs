using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menus : MonoBehaviour
{
    GameObject gameManagerObj;
    GameManager gM;

    GameObject player;
    PlayerStatManager playerStats;

    public string charName;

    public string[] kin = {"Human", "Vampire", "Chyiid", "Cold Blooded", "Horror"};
    public string selectedKin;

    public string[] desire;
    public string selectedDesire;

    public GameObject wantedPosterCreation;
    public GameObject desireSelection;

    public string desireOpt1Name;
    public GameObject desireOption1;
    public string desireOpt2Name;
    public GameObject desireOption2;
    public string desireOpt3Name;
    public GameObject desireOption3;


    // Start is called before the first frame update
    void Start()
    {
        wantedPosterCreation.SetActive(true);
        desireSelection.SetActive(false);

        gameManagerObj = GameObject.FindGameObjectWithTag("GameManager");
        //gM = gameManagerObj.GetComponent<GameManager>();

        player = GameObject.FindGameObjectWithTag("Player");
        //playerStats = player.GetComponent<PlayerStatManager>();

        selectedKin = kin[0];
        selectedDesire = "null";

        //this should change to unlocked desires
        //desire = gM.allDesires;


        ////desireOption1.GetComponent<TextMeshPro>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void NextKin()
    {

    }

    public void NextMenu()
    {
        desireSelection.SetActive(true);
        wantedPosterCreation.SetActive(false);
    }

    public void SelectDesire()
    {
        SceneManager.LoadScene(1);
    }
    
}
