using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForagePickup : MonoBehaviour
{

    public bool canHarvest = true;
    Animator plantAnimator;

    [SerializeField]
    private int maxGrowTime;
    [SerializeField]
    private int maxGrowStage;

    public float growTime;

    public int growStage;

    // Start is called before the first frame update
    void Start()
    {
        canHarvest = true;
        growStage = maxGrowStage;
        growTime = 0;
        plantAnimator = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        

        if (growStage < maxGrowStage)
        {
            growTime += Time.deltaTime;
            if (growTime >= maxGrowTime)
            {
                growTime = 0;
                growStage ++;
                plantAnimator.SetTrigger("growTrigger");
            }
        }
        else if (growStage == maxGrowStage)
        {
            canHarvest = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && canHarvest == true)
        {
            ForageItem();
        }
    }

    void ForageItem()
    {
        canHarvest = false;
        growStage = 1;
        plantAnimator.SetTrigger("growTrigger");


    }
}
