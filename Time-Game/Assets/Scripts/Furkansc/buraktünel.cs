using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buraktünel : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
      
        if (other.CompareTag("cave"))
        {
           
            Invoke("OyunuDurdur", 1f);
        }
    }

    
    void OyunuDurdur()
    {
       SceneManager.LoadSceneAsync("ending");
    }

}
