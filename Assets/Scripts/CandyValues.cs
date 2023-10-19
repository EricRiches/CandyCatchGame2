using System.Collections;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using UnityEngine;

public class CandyValues : MonoBehaviour
{
    public int Worth = 100;
    public int spawnChance = 1;

    Collectibles Candy;

    private void Awake()
    {
        Candy = new Collectibles("Candy", 1, 0);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Candy.UpdateScore(Worth);
            Destroy(gameObject);
        }
    }
}
