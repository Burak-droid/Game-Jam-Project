using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class MovingCharacter : MonoBehaviour
{
    public float movingSpeed = 5f;
    public float jumpPower = 10f;
    public bool onfloor = true;
    Rigidbody2D rb;
    private float chScaleX, chScaleY, chScaleZ;

    Transform firepoint;


    private Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        chScaleX = transform.localScale.x;
        chScaleY = transform.localScale.y;
        chScaleZ = transform.localScale.z;
        anim = GetComponent<Animator>();
        firepoint = transform.GetChild(0);
    }

   
    void Update()
{
    float yatayHareket = Input.GetAxis("Horizontal");
    float dikeyHareket = Input.GetAxis("Vertical");

    Vector2 hareket = new Vector2(yatayHareket, 0f);
    rb.velocity = new Vector2(hareket.x * movingSpeed, rb.velocity.y);
    if (yatayHareket > 0)
    {
            transform.localScale = new Vector3(chScaleX, chScaleY, chScaleZ);

            firepoint.localScale = new Vector2(yatayHareket,0f);
            anim.SetBool("running",true);
        
            
    }
    else if (yatayHareket < 0)
    {
            transform.localScale = new Vector3(-chScaleX, chScaleY, chScaleZ);
            firepoint.localScale = new Vector2(yatayHareket,-0f);
            anim.SetBool("running",true);
        
            
    }
    else { 
            anim.SetBool("running",false);
        }
    if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && onfloor)
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        onfloor = false;
    }
}

void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Platform"))
    {
        onfloor = true;
    }
    
     else if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && onfloor==true)
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        onfloor = false;
    }
}
}
