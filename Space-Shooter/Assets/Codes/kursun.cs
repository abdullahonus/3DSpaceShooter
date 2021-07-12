using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AstreoidHareketi : MonoBehaviour
{
    Rigidbody fizikc;
    public int hiz;
    AudioSource audio;
    void Start()
    {
        fizikc = GetComponent<Rigidbody>();
        fizikc.velocity = transform.forward * hiz;
        audio = GetComponent<AudioSource>();
        audio.Play();
    }

 
}
