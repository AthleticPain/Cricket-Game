using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatSpawner : MonoBehaviour
{
    public GameObject[] bats;
    public Joystick joystick;

    public GameObject selectedBat;


    private void Start()
    {
        if(!selectedBat)
        {
            SpawnBat(0);
        }
    }

    public void changeSelectedBat(int index)
    {
        Destroy(selectedBat.gameObject);
        SpawnBat(index);
        Debug.Log("Joystick Set Spawner End");
    }

    private void SpawnBat(int index)
    {
        selectedBat = Instantiate(bats[index], transform.position, Quaternion.identity);
        selectedBat.GetComponent<BatJoystick>().SetJoystick(joystick);
    }
}
