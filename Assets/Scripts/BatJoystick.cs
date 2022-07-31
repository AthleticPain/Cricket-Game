using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatJoystick : MonoBehaviour
{
    public Joystick joystick;
    public float joystickMovementRange = 100f;
    public float batHorizontalMovementRange = 2f;
    public float batVerticalMovementRange = 5f;
    public float rotationOffset = 180f;

    Rigidbody2D rb;

    Vector2 batStartingPos;

    private bool isControllable = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        batStartingPos = transform.position;
    }

    private void FixedUpdate()
    {
        if (joystick)
        {
            if (isControllable)
            {
                float deltaHorizontal = joystick.GetJoystickXPosition() * batHorizontalMovementRange / joystickMovementRange;
                float deltaVertical = joystick.GetJoystickYPosition() * batVerticalMovementRange / joystickMovementRange;

                rb.MovePosition(new Vector2(batStartingPos.x + deltaHorizontal, batStartingPos.y + deltaVertical));


                float batAngle = Mathf.Acos(-deltaHorizontal / batHorizontalMovementRange) * Mathf.Rad2Deg;

                Debug.Log("Acos(" + deltaHorizontal + "/" + batHorizontalMovementRange + ") = " + batAngle);

                rb.MoveRotation(batAngle + rotationOffset);
            }


        }
    }

    public void SetJoystick(Joystick joystickToBeAssigned)
    {
        joystick = joystickToBeAssigned;
    }
}
