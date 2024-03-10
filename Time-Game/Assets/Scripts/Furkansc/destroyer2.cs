using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer2 : MonoBehaviour
{
    public string platformTag = "Platform";
    public string borderTag = "Border";
    public string playerTag = "Player";

    private void OnTriggerEnter2D(Collider2D other)
    {

        string collidedTag = other.tag;

        if (collidedTag == platformTag || collidedTag == borderTag || collidedTag == playerTag)
        {
            Destroy(gameObject);
        }
    }
}
