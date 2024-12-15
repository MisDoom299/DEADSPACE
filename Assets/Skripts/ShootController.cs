using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    public GameObject bullet;
    void Update()
    {
        Instantiate(bullet);
    }
}
