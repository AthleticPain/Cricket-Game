using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrackedPitch : MonoBehaviour
{
    public float maxVariation = 2f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (rb.velocity.magnitude > 10f)
            {
                rb.velocity += new Vector2(Random.Range(-maxVariation, maxVariation), Random.Range(-maxVariation, maxVariation));
            }
        }
    }
}
