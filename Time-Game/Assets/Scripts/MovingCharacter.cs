using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCharacter : MonoBehaviour
{
    public float movingSpeed = 5f;
    public float jumpPower = 10f;
    public bool onfloor = true;
    public bool movingCharacterright = false;
    public bool movingCharacterleft = false;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
{
    float yatayHareket = Input.GetAxis("Horizontal");
    float dikeyHareket = Input.GetAxis("Vertical");

    Vector2 hareket = new Vector2(yatayHareket, 0f);
    rb.velocity = new Vector2(hareket.x * movingSpeed, rb.velocity.y);
    if (yatayHareket > 0)
    {
        transform.localScale = new Vector3(1, 1, 1);
            movingCharacterright = true;
    }
    else if (yatayHareket < 0)
    {
        transform.localScale = new Vector3(-1, 1, 1);
            movingCharacterleft = true;
    }
    else { movingCharacterright = false;
            movingCharacterleft = false;
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
