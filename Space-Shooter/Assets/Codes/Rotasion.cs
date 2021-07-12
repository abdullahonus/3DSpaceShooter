using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class kursun : MonoBehaviour
{
    Rigidbody fizikc;
    public float hiz;

    void Start()
    {
        fizikc = GetComponent<Rigidbody>();
        fizikc.velocity = transform.forward * hiz;

    }


}
