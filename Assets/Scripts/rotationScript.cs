using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotationScript : MonoBehaviour
{
    public float rotationSpeed = 30f;
    // Start is called before the first frame update
    void Start()
    {
    
}

    // Update is called once per frame
    void Update()
    {
    // Rotate the object around its up (Y) axis
    transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
}
}
