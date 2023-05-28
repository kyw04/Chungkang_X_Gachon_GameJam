using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private BoxCollider Trigger;
    private float hp;
    
    private bool isTrigger; // 다른 물체와 접촉(관통)하고 있는지 확인합니다.

    void Start()
    {
        Trigger = GetComponent<BoxCollider>(); 
        hp = 100.0f;
        isTrigger = false;
    }

    private void OnTriggerEnter(Collider other) 
    {
        isTrigger = true;
        hp -= 20f;
    }
    private void OnTriggerExit(Collider other)
    {
        isTrigger = false;
    }
}
