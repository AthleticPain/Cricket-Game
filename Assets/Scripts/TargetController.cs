using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public Camera cam;
    public Transform target;

    public void TouchDetected()
    {
        Debug.Log("Touch Detected");
    }

    private void OnMouseDown()
    {
        Debug.Log("MouseDown Detected");
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckMouseClick();
        }
    }

    private void CheckMouseClick()
    {
        Ray2D ray = new Ray2D(cam.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y)), Vector2.zero);
        RaycastHit2D hitInfo2D = Physics2D.Raycast(ray.origin, ray.direction);

        if (hitInfo2D.collider != null && hitInfo2D.collider.tag == "Pitch")
        {
            //Debug.Log("Mouse Hit " + hitInfo2D.point);
            target.position = new Vector2(hitInfo2D.point.x, target.position.y);
        }
    }
}
