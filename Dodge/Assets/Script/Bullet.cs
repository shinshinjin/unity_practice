using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = transform.forward * speed;

        Destroy(gameObject, 3f);
    }

   void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if(playerController != null)
            {
                playerController.Die();
            }
        }
    }

    /* 
    public float Speed = 0.1f;

    void Update()
    {
        transfrom.Translate(0f, 0f, Speed);
    }
    */

}
