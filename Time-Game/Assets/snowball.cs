using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowball : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D rb;
    private bool facingRight = true; // Karakterin varsayılan olarak sağa baktığını varsayalım

    void Update()
    {
        rb.velocity = transform.right*speed;
    
    if(!facingRight){

        rb.velocity = transform.right*speed;
    }
}
     void OnTriggerEnter2D(Collider2D hitInfo) {

       Enemy enemy= hitInfo.GetComponent<Enemy>();
        if(enemy != null){ 
                enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
