using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyour : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    private void Start() {
        rb = GetComponent<Rigidbody2D>();  
    }
    void FixedUpdate() {
        Vector2 pos = rb.position;
        rb.position += Vector2.left * speed * Time.fixedDeltaTime;
        rb.MovePosition(pos);
    }
}
