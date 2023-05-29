using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public int selectEnemy;
    public float spawnSpeed = 1.5f;

    private float lastSpawnTime;

    private void Update()
    {
        selectEnemy = Random.Range(0, enemyPrefab.Length);
        if (lastSpawnTime + spawnSpeed <= Time.time)
        {
            lastSpawnTime = Time.time;
            Instantiate(enemyPrefab[selectEnemy], transform.position, Quaternion.identity);
        }
    }
}
