
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimalSpawn : MonoBehaviour
{
    public GameObject[] Zombie;

    private int index;
    private Vector3 position;
    private void Start()
   {
        InvokeRepeating("Spawn", 2, 3);
   }
    void Spawn()
    {
        position = new Vector3(Random.Range(167, 170), 12, Random.Range(121,123));
        index = Random.Range(0,Zombie.Length);
        Instantiate(Zombie[index], position, Zombie[index].transform.rotation);
    }

    
}
