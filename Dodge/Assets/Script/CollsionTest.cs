using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollsionTest : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log($"[OnCollisionEnter] Me : {gameObject.name}, Other : {collision.gameObject.name}");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log($"[OnCollisionExit] Me : {gameObject.name}, Other : {collision.gameObject.name}");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"[OnTriggerEnter] Me : {gameObject.name}, Other : {other.gameObject.name}");
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log($"[OnTriggerStay] Me : {gameObject.name}, Other : {other.gameObject.name}");
    }
}
