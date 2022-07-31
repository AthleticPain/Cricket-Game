using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudPitch : MonoBehaviour
{
    public float dampeningFactor = 1.5f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(rb.velocity.x / dampeningFactor, rb.velocity.y / dampeningFactor);
        }
    }
}