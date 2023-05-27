using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator attackAni;
    public Transform attackBox;
    public float attackDelay = 1.5f;

    private float lastAttackTime;

    private void Start()
    {
        lastAttackTime = 0f;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && lastAttackTime + attackDelay <= Time.time)
        {
            //Debug.Log("Attack!");
            lastAttackTime = Time.time;

            attackAni.SetTrigger("Attack");

            //Collider[] colliders = Physics.OverlapBox(attackBox.position, attackBox.localScale, attackBox.rotation);
            Collider[] colliders = Physics.OverlapBox(attackBox.position, attackBox.localScale / 2, attackBox.rotation, LayerMask.GetMask("Enemy"));
            foreach (Collider collider in colliders)
            {
                Debug.Log(collider.name);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.matrix = transform.localToWorldMatrix;
        Vector3 attackBoxPos = transform.position;
        attackBoxPos.y = 0;
        attackBoxPos += attackBox.localPosition;
        Gizmos.DrawWireCube(attackBoxPos, attackBox.localScale);
    }
}
