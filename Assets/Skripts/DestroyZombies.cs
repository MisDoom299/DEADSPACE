using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZombies : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
   {

        if (other.gameObject.CompareTag("Zombie"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        
   
    
    }
}

