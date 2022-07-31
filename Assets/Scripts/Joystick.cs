using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour
{
    Vector2 startingPos;

    private void Start()
    {
        startingPos = transform.position;
    }

    public float GetJoystickAngle()
    {
        Vector2 difference = startingPos - new Vector2(transform.position.x, transform.position.y);
        difference.Normalize();
        float angle = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        return angle;
    }

    public float GetJoystickXPosition()
    {
        float xval = transform.position.x - startingPos.x;
        Debug.Log("X Value = " + xval);
        return xval;
    }    
    
    public float GetJoystickYPosition()
    {
        float yval = transform.position.y - startingPos.y;
        Debug.Log("Y Value = " + yval);
        return yval;
    }
}
