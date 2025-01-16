using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZOMBIEMOVE : MonoBehaviour
{
    private Transform Player;
    private Vector3 direction;
    private float speed = 3f;
    private float attackRange = 3f;
    private  float distanceToPlayer;
    void Start()
    {
        Player = GameObject.Find("Player").transform;
    }

    
    void Update()
    {
      distanceToPlayer = Vector3.Distance(transform.position, Player.position);

        if (distanceToPlayer <= attackRange) 
        {
          direction = (transform.position  - Player.position).normalized;

           transform.Translate(direction * Time.deltaTime * speed);
        }
    
    }
}
