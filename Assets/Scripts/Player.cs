using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform gun;
    public Transform gun2;
    public GameObject prefab;
    public int bulletType;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Jump"))
        {
            GameObject bullet = PoolManager.instance.GetPoolObject(bulletType);
            bullet.transform.position = gun.position;
            bullet.SetActive(true);
        }

        if (Input.GetButtonDown("Jump"))
        {
            GameObject bullet = PoolManager.instance.GetPoolObject(bulletType);
            bullet.transform.position = gun2.position;
            bullet.SetActive(true);
        }
    }
}