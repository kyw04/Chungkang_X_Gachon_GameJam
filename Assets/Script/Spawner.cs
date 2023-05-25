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
        if (lastSpawnTime + spawnSpeed <= Time.time)
        {
            Debug.Log("Àû ¼ÒÈ¯ µÊ");
            Instantiate(enemyPrefab[selectEnemy], transform.position, Quaternion.identity);
        }
    }
}
