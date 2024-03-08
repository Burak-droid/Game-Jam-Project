using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCharacter : MonoBehaviour
{
    public float movingSpeed = 5f;
    public float bulletSpeed;
    public float jumpPower = 10f;
    public bool onfloor = true;
    public bool movingCharacterright = false;
    public bool movingCharacterleft = false;
    Rigidbody2D rb;
    GameObject tempBullet;
    public GameObject bullet;
    private float chScaleX, chScaleY, chScaleZ;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        chScaleX = transform.localScale.x;
        chScaleY = transform.localScale.y;
        chScaleZ = transform.localScale.z;

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
            movingCharacterright = true;
            movingCharacterleft = false;

    }
    else if (yatayHareket < 0)
    {
        transform.localScale = new Vector3(-chScaleX, chScaleY, chScaleZ);
            movingCharacterleft = true;
            movingCharacterright = false;
    }
    else { movingCharacterright = false;
            movingCharacterleft = false;
            movingCharacterright = false;
        }
        animator.SetBool("IsMovingRight", movingCharacterright);
        animator.SetBool("IsMovingLeft", movingCharacterleft);
    if ((Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && onfloor)
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        onfloor = false;
    }
    if (Input.GetKeyDown(KeyCode.Space))
    {
            ShootBullet();
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
    void ShootBullet()
    {
        tempBullet = Instantiate(bullet, muzzle.position, Quaternion.identity) as GameObject; // muzun dönmesi içim rotation ayarı yapılacak
        tempBullet.GetComponent<Rigidbody2D>().AddForce(muzzle.forward * bulletSpeed);
    }
}
