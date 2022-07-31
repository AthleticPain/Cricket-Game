using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WicketSpawner : MonoBehaviour
{
    public GameObject wicket;

    private GameObject wicketSpawned;

    private void Start()
    {
        wicketSpawned = Instantiate(wicket, transform.position, Quaternion.identity);
    }

    private void Update()
    {
        if(!wicketSpawned)
        {
            wicketSpawned = Instantiate(wicket, transform.position, Quaternion.identity);
        }
    }
}
