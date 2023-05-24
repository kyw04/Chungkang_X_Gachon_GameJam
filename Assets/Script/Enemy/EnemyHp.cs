using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    private BoxCollider enemyTrigger;
    private float enemyHp;

    // player의 trigger를 붙여준다.
    [SerializeField]
    private BoxCollider playerTrigger;
    [SerializeField]
    private float playerHp;
    
    private bool isTrigger = false;
    void Start()
    {
        enemyTrigger = GetComponent<BoxCollider>();
        enemyHp = 100;
    }
    private void OnTriggerEnter(Collider playerCollider)
    {
        isTrigger = true;
    }

    private void OnCollisionExit(Collision playerCollider)
    {
        isTrigger = false;
    }
}
