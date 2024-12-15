using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOVEskript : MonoBehaviour
{
    private int speed = 20;
    private int rotationSpeed = 80;
    public float horizontal;
    public float vertical;

    void Update()

    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontal);

    }
       
}
