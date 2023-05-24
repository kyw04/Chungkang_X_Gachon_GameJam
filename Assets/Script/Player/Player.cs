using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private BoxCollider Trigger;
    private bool isTrigger = false;
    void Start()
    {
        Trigger = GetComponent<BoxCollider>();
    }
}
