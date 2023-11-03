using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject spawnerBullets;
    public GameObject bulletPrefab;
    public float force;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Shoot()
    {
        GameObject temp = Instantiate(bulletPrefab, spawnerBullets.transform.position, spawnerBullets.transform.rotation);
        temp.GetComponent<Rigidbody>().AddForce(transform.forward * force *100f);
    }
}
