using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    
    public GameObject bullet;
    public Transform barrel;
    private Quaternion bulletRotation;
    void Update()
    { 
    if (Input.GetMouseButtonDown(0))
    {
       bulletRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y,-90);
       if (Input.GetMouseButtonDown(0)) 
       {                
        Instantiate(bullet,barrel.position ,bulletRotation);
       }
    }
    
    
    
    }
    

       
    
}
