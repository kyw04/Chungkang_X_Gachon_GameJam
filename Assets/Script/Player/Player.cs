using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private BoxCollider Trigger;
    public float hp;

    private bool isTrigger; // 다른 물체와 접촉(관통)하고 있는지 확인합니다.

    public Vector3 inputVec;
    public float speed;

    Rigidbody rigid;
    SpriteRenderer spriter;
    Animator anim;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        spriter = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        Trigger = GetComponent<BoxCollider>(); 
        hp = 100.0f;
        isTrigger = false;
    }

    void Update()
    {
        inputVec = Vector3.zero;
        inputVec.x = Input.GetAxisRaw("Horizontal");
        inputVec.z = Input.GetAxisRaw("Vertical");
        anim.SetFloat("Move", inputVec.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        Vector3 nextVec = inputVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);
    }

    private void LateUpdate()
    {
        //anim.SetFloat("Speed", inputVec.magnitude);
        if (inputVec.x != 0)
        {
            spriter.flipX = inputVec.x < 0;
        }
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
