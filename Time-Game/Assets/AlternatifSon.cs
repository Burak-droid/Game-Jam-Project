using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternatifSon : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.CompareTag("Player")){
            //Mutlu Son
        }
    }
}
