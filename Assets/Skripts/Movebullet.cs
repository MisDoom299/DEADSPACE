using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movebullet : MonoBehaviour
{
    private int speed = 15;
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
