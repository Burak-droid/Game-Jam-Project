using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyour : MonoBehaviour
{
    public float conveyourSpeed = 2f;
    Vector2 speed;
    
    private void Start() {
        speed = new Vector2(conveyourSpeed, 0f);
    }
    private void OnCollisionStay2D(Collision2D other) {
        
        if (other.gameObject.CompareTag("Player")){
            other.rigidbody.AddForce(speed);
        }
    }
}