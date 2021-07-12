using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MermiTeması : MonoBehaviour
{
    public GameObject patlama;
    public GameObject playerPatlama;

    GameObject OyunConrol;
    OyunConrol kontrol;

    

    void Start()
    {
        OyunConrol = GameObject.FindGameObjectWithTag("oyunkontrol");
            kontrol = OyunConrol.GetComponent<OyunConrol>();
        
    }
   

    
    void OnTriggerEnter(Collider col)
    {

        if (col.tag != "engel")
        {

            Destroy(col.gameObject);
            Destroy(gameObject);

            Instantiate(patlama, transform.position, transform.rotation);
            kontrol.ScoreArttır(10);
        }
            if (col.tag == "Player")
            {
                Instantiate (playerPatlama,col.transform.position,col.transform.rotation);
                kontrol.oyunBitti();
            }

        
      
    }
}
