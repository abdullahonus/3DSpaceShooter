using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sınır : MonoBehaviour
{
    public GameObject kursunn;
    void OnTriggerExit(Collider other) {



        Destroy(GameObject.Find("kursun(Clone)"));

          
      
    }

    }

