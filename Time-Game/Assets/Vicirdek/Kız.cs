using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kız : MonoBehaviour
{
    private Animator ending;
    private float edge = 33.2f, Hava = 35f;
    private float chScaleX, chScaleY, chScaleZ;
    public float waitTime = 5f;
    public float speed = 2f, fallSpeed = 15f;
    public GameObject girl;
    public GameObject alternatifSon;
    public bool IsTriggered = false;
    public bool OnEdge = false, activated = false, OnAir = false;
    private void Start() {
        chScaleX = transform.localScale.x;
        chScaleY = transform.localScale.y;
        chScaleZ = transform.localScale.z;
        ending = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.CompareTag("Player")){
            transform.localScale = new Vector3 (-chScaleX, chScaleY, chScaleZ);
            Invoke("play", waitTime);
        }
    }
    private void play(){
        IsTriggered = true;
        ending.SetBool("IsTriggered", true);
        activated = true;

    }
    private void Update(){
        if (transform.position.x >= edge){
            OnEdge = true;
            ending.SetBool("OnEdge", true);
        }
        if (OnEdge){
            transform.Translate(new Vector2(0f,0f));
        }
        if (!OnEdge && activated){
            transform.Translate(Vector2.right * Time.deltaTime * speed);  
        }
        if (OnEdge){
            Invoke("atlama", waitTime);
        }
        if (OnAir){
            transform.Translate(new Vector2(0f, -1f) * Time.deltaTime * fallSpeed);
            alternatifSon.SetActive(true);
        }
        if (transform.position.x >= Hava){
            OnAir = true;
        }
}
    private void atlama(){
        transform.Translate(new Vector2(2f, 0f) * Time.deltaTime * speed);
    }
}