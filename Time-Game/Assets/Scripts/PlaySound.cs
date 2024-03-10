using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
AudioSource audio;
private void Start() {
    audio = GetComponent<AudioSource>();
}
public void Play(){
    audio.Play();
}
}

