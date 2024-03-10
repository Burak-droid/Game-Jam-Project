using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    public string platformTag = "Platform";
    public string borderTag = "Border";
    public string enemyTag = "Enemy";

    private void OnTriggerEnter2D(Collider2D other)
    {

        string collidedTag = other.tag;


        if (collidedTag == enemyTag)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        else if (collidedTag == platformTag || collidedTag == borderTag)
        {
            Destroy(gameObject);
        }
    }
}
