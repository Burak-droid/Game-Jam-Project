using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed = 0.02f;
    public float panelCloseDelay = 2f; // Panelin kapanması için beklenen süre
    private int index;

    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }

        // Metin tamamlandıktan sonra belirli bir süre sonra ClosePanel fonksiyonunu çağır
        Invoke("ClosePanel", panelCloseDelay);
    }

    void ClosePanel()
    {
        gameObject.SetActive(false); // Paneli devre dışı bırakır
    }
}
