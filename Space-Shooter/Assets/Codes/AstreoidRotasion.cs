using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstreoidRotasion : MonoBehaviour
{
    Rigidbody fizikc;
    public int hiz;

    void Start()
    {
        fizikc = GetComponent<Rigidbody>();
        fizikc.velocity = transform.forward * hiz;
    }
    

}
