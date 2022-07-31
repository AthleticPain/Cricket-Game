using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject[] balls;
    public Transform target;
    public float ballSpeed = 100f;

    private GameObject selectedBall;

    private void Start()
    {
        SelectBall(0);
    }

    public void CreateNewBall()
    {
        GameObject ballSpawned = Instantiate(selectedBall, transform.position, Quaternion.identity);
        AddForceToBall(ballSpawned);
    }

    private void AddForceToBall(GameObject ball)
    {
        Vector2 direction = (target.position - transform.position).normalized;
        //ball.GetComponent<Rigidbody2D>().AddForce(direction * ballSpeed);
        ball.GetComponent<Rigidbody2D>().velocity = ballSpeed * direction;
    }

    public void SelectBall(int index)
    {
        selectedBall = balls[index];
    }

}
