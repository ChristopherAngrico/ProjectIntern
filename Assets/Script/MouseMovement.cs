using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    private void Update()
    {
        Transform draggingObject = transform;

        float planeY = 0;
        Plane plane = new Plane(Vector3.up, planeY); // ground plane

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        float distance; // the distance from the ray origin to the ray intersection of the plane
        if (plane.Raycast(ray, out distance))
        {
            draggingObject.position = ray.GetPoint(distance); // distance along the ray
        }
    }
}
