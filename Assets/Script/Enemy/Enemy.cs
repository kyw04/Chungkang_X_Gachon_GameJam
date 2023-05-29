using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float damage = 5f;
    public float attackDelay = 0.5f;
    public Rigidbody target;

    public bool isLive = true;

    private float lastAttack;
    public Rigidbody rigid;
    SpriteRenderer spriter;
    Animator ani;

    void Awake()
    {
        lastAttack = 0f;
        rigid = GetComponent<Rigidbody>();
        spriter = GetComponentInChildren<SpriteRenderer>();
        ani = GetComponentInChildren<Animator>();
    }

    void FixedUpdate()
    {
        if (!isLive)
            return;

        Vector3 dirVec = target.position - rigid.position;
        Vector3 nextVec = dirVec.normalized * speed * Time.fixedDeltaTime;
        rigid.MovePosition(rigid.position + nextVec);
        //rigid.velocity = Vector3.zero;
    }

    private void LateUpdate()
    {
        if (!isLive)
        {
            ani.speed = 0;
            spriter.color = Color.gray;
            Destroy(this.gameObject, 0.5f);
            return;
        }

        spriter.flipX = target.position.x < rigid.position.x;
    }

    private void OnEnable()
    {
        target = GameManager.instance.player.GetComponent<Rigidbody>();
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && attackDelay + lastAttack <= Time.time)
        {
            Debug.Log("АјАн");
            lastAttack = Time.time;
            collision.gameObject.GetComponent<Player>().hp -= damage;
        }
    }
}