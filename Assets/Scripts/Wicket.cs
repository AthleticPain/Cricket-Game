using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wicket : MonoBehaviour
{
    Vector2 wicketStartingPos;

    private void Start()
    {
        wicketStartingPos = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Pitch")
        {
            Debug.Log("Out!");
            StartCoroutine(WaitBeforeResettingWicket());
        }
    }

    IEnumerator WaitBeforeResettingWicket()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }

    public void ResetWicket()
    {
        GetComponent<Rigidbody2D>().SetRotation(0);
        GetComponent<Rigidbody2D>().MovePosition(wicketStartingPos);
    }
}
