using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public int damage;
    public float fireRate;
    private float timeToFire;

    public int maxAmmo;
    public int curAmmo;

    public float reloadTime;

    private bool reloading;
    public Transform gun;
    private Quaternion gunRot;

    public Transform cam;

    public LayerMask layerMask;

    public GameObject hitFX;
    public ParticleSystem muzzleFlash;

    private void Start()
    {
        gunRot = gun.localRotation;

        curAmmo = maxAmmo;
    }

    private void Update()
    {
        if (timeToFire > 0) timeToFire -= Time.deltaTime;
        //on finish reload
        else if (reloading)
        {
            reloading = false;
            gun.localRotation = gunRot;

            curAmmo = maxAmmo;
        }

        if(reloading)
        {
            gun.Rotate(Vector3.right, Time.deltaTime * 2000, Space.Self);
        }

        if (Input.GetButtonDown("Fire1") && timeToFire <= 0 && curAmmo > 0)
        {
            Fire();
        }

        if (Input.GetKeyDown(KeyCode.R) && !reloading && curAmmo < maxAmmo)
        {
            Reload();
        }
    }

    public void Fire()
    {
        timeToFire = 1f / fireRate;
        curAmmo--;

        muzzleFlash.Play();

        //raycast
        RaycastHit hit;
        if(Physics.Raycast(cam.position, cam.forward, out hit, 200f, layerMask))
        {
            //spawn impact particles & destroy after 3 seconds
            Destroy(Instantiate(hitFX, hit.point, Quaternion.LookRotation(hit.normal)), 3f);

            //check for health component & damage it
            HealthComponent health = hit.collider.gameObject.GetComponent<HealthComponent>();
            if (health != null)
            {
                health.TakeDamage(damage);
            }
        }

        if(curAmmo <= 0)
        {
            Reload();
        }
    }

    public void Reload()
    {
        gun.Rotate(Vector3.forward, 90, Space.Self);

        timeToFire = reloadTime;
        reloading = true;

        print("Reloading");
    }
}
