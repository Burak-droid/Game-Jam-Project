using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monkeyhealth : MonoBehaviour
{

    private float canSayisi = 5;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("border"))
        {
            if (other.gameObject.CompareTag("border"))
            {
                canSayisi = 0;
                if (canSayisi <= 0)
                {
                    Invoke("YenidenYukle", 1f);
                }
            }
            else if(other.gameObject.CompareTag("Enemy"))
            {
                canSayisi= canSayisi- 0.5f;
                Debug.Log(canSayisi+"  1");
                if (canSayisi <= 0)
                {
                    Invoke("YenidenYukle", 1f);
                    canSayisi = 5;
                }
            }
        }
    }

    private void YenidenYukle()
    {
        int sahneIndeksi = SceneManager.GetActiveScene().buildIndex;
        canSayisi = 5;
        Debug.Log(canSayisi + "  2");
        SceneManager.LoadScene(sahneIndeksi);

    }
}
