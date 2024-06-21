using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackInteract : MonoBehaviour
{
    [SerializeField]
    private GameObject bullet;

    public Transform bulletSpawn;
    public Transform bulletAim;
    public int bulletSpeed;

    public bool canAttack = true;

    // Start is called before the first frame update
    void Start()
    {
        canAttack = true;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerAttack();
    }

    void PlayerAttack()
    {
        if (Input.GetMouseButtonDown(0) && canAttack)
        {
            Debug.Log("shoot");
            //GameObject bulletInstance = Instantiate(bullet, bulletSpawn.position, bulletAim.localRotation);
            //bulletInstance.GetComponent<Rigidbody>().velocity = bulletAim.localPosition * bulletSpeed;
        }
            
    }

   
}
