using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnanasSpawner : MonoBehaviour
{
    public GameObject enemy;
    public Transform Flower;
    public float shootInterval = 1.5f;
    private float shootTimer = 0f;
    public float destroyInterval = 4.5f;
    private float destroyTimer = 0f;

    void Update()
    {
        shootTimer += Time.deltaTime;
        destroyTimer += Time.deltaTime; 

        if (shootTimer >= shootInterval)
        {
            Shoot();
            shootTimer = 0f;
        }
        if (destroyTimer >= destroyInterval)
        {
            DestroyEnemy();
            destroyTimer = 0f;
        }
    }
    void Shoot()
    {
        GameObject Go = Instantiate(enemy, Flower.position, Quaternion.identity);
        Rigidbody2D rb = Go.GetComponent<Rigidbody2D>(); 
        if (rb != null)
        {
            rb.AddForce(Vector2.right * 300f);
        }
    }
    void DestroyEnemy()
    {

        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }

    }
}
