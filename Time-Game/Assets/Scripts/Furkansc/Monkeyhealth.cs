using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Monkeyhealth : MonoBehaviour
{
    private float canSayisi = 5;
    public Slider healthSlider;
    private bool dialogShown = false;

    void Start()
    {
        healthSlider.maxValue = canSayisi;
        healthSlider.value = canSayisi;
        if (!PlayerPrefs.HasKey("DialogShown"))
        {
            ShowDialog();
            PlayerPrefs.SetInt("DialogShown", 1);
        }
    }

    private void ShowDialog()
    {
        GameObject dialogPanel = GameObject.FindGameObjectWithTag("DialogPanel");
        if (dialogPanel != null && !dialogShown)
        {
            dialogPanel.GetComponent<Dialog>().ResetDialogue();
            dialogPanel.SetActive(true);
            dialogShown = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy") || other.gameObject.CompareTag("border"))
        {
            if (other.gameObject.CompareTag("border"))
            {
                canSayisi = 0;
                if (canSayisi <= 0)
                {
                    Invoke("YenidenYukle", 0.5f);
                }
            }
            else if (other.gameObject.CompareTag("Enemy"))
            {
                canSayisi = canSayisi - 0.5f;
                healthSlider.value = canSayisi;
                Debug.Log(canSayisi + "  1");
                if (canSayisi <= 0)
                {
                    Invoke("YenidenYukle", 0.5f);
                    canSayisi = 5;
                }
            }
        }
    }

    private void YenidenYukle()
    {
        int sahneIndeksi = SceneManager.GetActiveScene().buildIndex;
        canSayisi = 5;
        healthSlider.value = canSayisi;
        Debug.Log(canSayisi + "  2");
        SceneManager.LoadScene(sahneIndeksi);
        PlayerPrefs.DeleteKey("DialogShown"); // Reset the PlayerPrefs key
    }

    // Bu kod, karakter öldüğünde diyalog balonlarını kapatır


}
