using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateOnLook : MonoBehaviour
{
    public float rotationSpeed = 30f;
    private bool isBeingLookedAt = false;

    // Update is called once per frame
    void Update()
    {
        if (isBeingLookedAt)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {
        // Create a ray from the camera's position and forward direction
        Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
        RaycastHit hit;

        // Check if the ray hits the object
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject == gameObject)
            {
                isBeingLookedAt = true;
            }
            else
            {
                isBeingLookedAt = false;
            }
        }
        else
        {
            isBeingLookedAt = false;
        }
    }
}
