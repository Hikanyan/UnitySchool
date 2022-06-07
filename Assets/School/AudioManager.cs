using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AudioManager : MonoBehaviour
{
    private AudioSource audio;
    public AudioClip sound01;
    public AudioClip sound02;
    public AudioClip sound03;
    private GameObject Effect;
    public GameObject effect01;
    void Start()
    {
        audio = gameObject.AddComponent<AudioSource>();
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Blue")
        {
            audio.PlayOneShot(sound01);
        }
        else if (other.gameObject.tag == "Block")
        {
            audio.PlayOneShot(sound02);
        }
        else audio.PlayOneShot(sound03);
    }
}