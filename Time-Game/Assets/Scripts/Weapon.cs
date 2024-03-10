using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
 AudioSource audio; 
    public Transform firePoint;
    public GameObject snowballPrefab;
    // Update is called once per frame
    private void Start() {
    audio = GetComponent<AudioSource>();
}
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){ 
            Shoot();
        }
    }

    void Shoot(){ 
        Instantiate(snowballPrefab, firePoint.position, firePoint.rotation);
        audio.Play();
    }

}