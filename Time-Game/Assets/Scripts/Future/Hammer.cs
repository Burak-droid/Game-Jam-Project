using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Hammer : MonoBehaviour
{


    public GameObject gameObject;
    void Update(){

    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){
            int sahneIndeksi = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sahneIndeksi);
        }
    }
}
