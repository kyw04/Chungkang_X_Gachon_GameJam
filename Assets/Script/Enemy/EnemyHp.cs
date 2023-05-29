using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    public float enemyHp;
    private Enemy enemy;

    private void Start()
    {
        enemy = GetComponent<Enemy>();
    }

    private void Update()
    {
        if (enemyHp <= 0)
        {
            enemy.isLive = false;
        }
    }
}
