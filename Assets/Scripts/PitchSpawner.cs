using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchSpawner : MonoBehaviour
{
    public GameObject[] pitches;

    public GameObject selectedPitch;

    private void Start()
    {
        if(!selectedPitch)
        {
            selectedPitch = Instantiate(pitches[0], transform.position, Quaternion.identity);
        }
    }

    public void ChangeSelectedPitch(int index)
    {
        Destroy(selectedPitch.gameObject);
        selectedPitch = Instantiate(pitches[index], transform.position, Quaternion.identity);
    }
}
