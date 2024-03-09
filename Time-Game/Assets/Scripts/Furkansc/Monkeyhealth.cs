using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Monkeyhealth : MonoBehaviour
{
    private bool temasOldu = false;
    private int canSayisi = 3;

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
            else
            {
                temasOldu = true;
                canSayisi--;
                if (canSayisi <= 0)
                {
                    Invoke("YenidenYukle", 1f);
                }
            }
        }
    }

    private void YenidenYukle()
    {
        int sahneIndeksi = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sahneIndeksi);
    }
}
