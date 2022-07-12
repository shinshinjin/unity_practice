using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{

    public GameObject bulletPrefab;
    public float FirePos;
    public float spawnRateMin = 1f;
    public float spawnRateMax = 2f;

    private Transform target;
    private float spawnRate;
    private float timeAfterSpawn;
    bool isPlayer = false;

    void Start()
    {
        timeAfterSpawn = 0f;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
        target = FindObjectOfType<PlayerController>().transform;
    }

    void Update()
    {
        if (isPlayer == true)
        {
            timeAfterSpawn += Time.deltaTime;
            if (timeAfterSpawn > spawnRate)
            {
                timeAfterSpawn = 0f;

                GameObject bullet
                    = Instantiate(bulletPrefab, transform.position, transform.rotation);
                bullet.transform.LookAt(target);

                spawnRate = Random.Range(spawnRateMin, spawnRateMax);
            }

            if (Input.GetKeyDown(KeyCode.T))
            {
                Time.timeScale *= 0.5f;
            }
            gameObject.transform.LookAt(target);
        }

        transform.Rotate(0, 1, 0);
    }

    private void OnTriggerStay(Collider other)
    {
        isPlayer = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isPlayer = false;
    }

    /*
    public GameObject BulletPrefab;
    //바라보기
    public Transform Player

    private float _elapsedTime;

    void Start()
    {

    }

    
    void Update()
    {
        _elapsedTime += Time.deltaTime;
        if(_elapsedTime >= 0.5f)
        {
            _elapsedTime = 0f;
            Instantiate(BulletPrefab, transform);

            //bullet.transform.LookAt(Player);
        }
    }

     */
}
