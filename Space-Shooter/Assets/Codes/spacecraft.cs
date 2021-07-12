using System.Collections;
using System.Collections.Generic;

using System.Security.Cryptography;
using UnityEngine;

public class spacecraft : MonoBehaviour
{
    Rigidbody fizik;
    public int hiz;
    float ateszamanı=0;
    public GameObject kursun;
    public Transform KursunNerdenCıktı;

    void Start()
    {
        fizik=GetComponent<Rigidbody>();
    }

   void Update()
    {
        if (Input.GetKey(KeyCode.Space)&& Time.time>ateszamanı){
            ateszamanı = Time.time + 0.3f;
            Instantiate(kursun, KursunNerdenCıktı.position, Quaternion.identity);
            Debug.Log("ateşedildi");
            Destroy(GameObject.Find("kursun(Clone)"), 5.0f);
        }
   
        
    }
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");
        

       Vector3 vec = new Vector3(yatay, 0, dikey);
        fizik.AddForce(vec * hiz);
    }
} 