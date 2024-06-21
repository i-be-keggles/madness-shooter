using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public int numberOfPlants;

    //public bool isGloom = false;
    //public bool isWonder = false;
    //public bool isReal = true;

    //public float gloomMeter;
    //public float wondermeter;

    //public GameObject gloomFilter;
    //public GameObject wonderFilter;

    //public string[] unlockedDesires;
    public string[] allDesires = {"Riches", "Blood", "Violence", "Fame", "Peace", "Love", "Power"};

    //[SerializeField]
    //private GameObject plant;

    // Start is called before the first frame update
    void Start()
    {
        //numberOfPlants = Random.Range(5, 10);
        //for(int i = 0; i < numberOfPlants; i++)
        //{
        //    var posOfPlants = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
        //    Instantiate(plant, posOfPlants, Quaternion.identity);
        //}
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (isGloom || isWonder)
        //{
        //    isReal = false;
        //}
        //else if (!isGloom && !isWonder)
        //{
        //    isReal = true;
        //}

        //if (isReal)
        //{
        //    gloomFilter.SetActive(false);
        //    wonderFilter.SetActive(false);
        //}
        //else if (isGloom)
        //{
        //    isWonder = false;
        //    gloomFilter.SetActive(true);
        //    wonderFilter.SetActive(false);
        //}
        //else if (isWonder)
        //{
        //    isGloom = false;
        //    wonderFilter.SetActive(true);
        //    gloomFilter.SetActive(false);
        //}

    }
}
