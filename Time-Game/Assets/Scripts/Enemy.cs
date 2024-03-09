using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{


     private Vector3 locationA;
     private Vector3 locationB;
     private Vector3 nextLocation;

     [SerializeField] private Transform Enemys;

     [SerializeField] private Transform MovingtoLocation;

    public int health = 100;
    private Animator anim;
    public float speed;

    public GameObject deathEffect;


    void Start()
    {
          locationA=Enemys.localPosition;
          locationB = Enemys.localPosition;
          nextLocation=locationB;
          anim = GetComponent<Animator>();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

          void Update(){
                    anim.SetBool("isrunning", true);
                     Move();
          }
          
    private void Move(){ 

     Enemys.localPosition = Vector3.MoveTowards(Enemys.localPosition, nextLocation, speed * Time.deltaTime);

          if(Vector3.Distance(Enemys.localPosition,nextLocation) <= 0.1){
             
               ChangePosition(); 
                Debug.Log("çağrıldı");
          }

    }


    private void ChangePosition(){ 

     nextLocation = nextLocation != locationA ? locationA: locationB;

    }
    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
