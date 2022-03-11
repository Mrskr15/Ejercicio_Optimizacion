using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform enemySpawner;
    public GameObject prefab;
    public int bulletType;
    public float timeToSpawn = 3f, RangeSpawn = 3f;

    void Start()
    {
        InvokeRepeating ("Spawn", 0.0f, timeToSpawn);
    }

    // Update is called once per frame
    void Spawn()
    {
        Vector3 SpawnPosition = new Vector3 (0,0,0);
        SpawnPosition = this.transform.position + Random.onUnitSphere * RangeSpawn;
        SpawnPosition = new Vector3 (0, 2, SpawnPosition.z);

        GameObject Enemy = PoolManager.instance.GetPoolObject(1);
        Enemy.transform.position = SpawnPosition;
        Enemy.SetActive(true);
    }
}