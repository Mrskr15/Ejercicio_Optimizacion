using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemySpeed;

    Rigidbody _rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidBody.velocity = Vector3.forward * enemySpeed;
    }

    private void OnCollisionEnter(Collision collision) 
    {
        this.gameObject.SetActive(false);
    }
}