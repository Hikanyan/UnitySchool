using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    private AudioSource audio;
    public AudioClip sound2;
    private void Start()
    {
        audio = gameObject.AddComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision other)
    {
        
        
        if (other.gameObject.tag == "Target")
        {
            audio.PlayOneShot(sound2);
            Debug.Log("sound2");
        }
    }
}
