using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    GameObject[] Candy = new GameObject[6];
    public GameObject Candy1;
    public GameObject Candy2;
    public GameObject Candy3;
    public GameObject Candy4;
    public GameObject Candy5;
    public GameObject Candy6;

    GameObject[] Spawn = new GameObject[5];
    public GameObject Spawn1;
    public GameObject Spawn2;
    public GameObject Spawn3;
    public GameObject Spawn4;
    public GameObject Spawn5;

    int SpawnCount = 1;

    private void Start()
    {
        Candy[0] = Candy1;
        Candy[1] = Candy2;
        Candy[2] = Candy3;
        Candy[3] = Candy4;
        Candy[4] = Candy5;
        Candy[5] = Candy6;
        Spawn[0] = Spawn1;
        Spawn[1] = Spawn2;
        Spawn[2] = Spawn3;
        Spawn[3] = Spawn4;
        Spawn[4] = Spawn5;
        
        InvokeRepeating("SpawnCandy", 0, 1);
     
        
    }

    void SpawnCandy()
    {
        if (SpawnCount < 15)
        {
            SpawnCount = SpawnCount + 1;
            int ranCandy = Random.Range(0, 5);
            int ranSpawn = Random.Range(0, 4);
            Instantiate(Candy[ranCandy], Spawn[ranSpawn].transform.position, Quaternion.identity);
        }
        
    }
}
