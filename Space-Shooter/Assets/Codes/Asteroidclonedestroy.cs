using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroidclonedestroy : MonoBehaviour
{
    
    void OnTriggerExit(Collider dmn)
    {
        if(dmn.tag == "engel")
        {

        Destroy(gameObject,0.5f);
        
        }

    }


}
