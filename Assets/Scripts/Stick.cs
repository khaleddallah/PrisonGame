using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    // This code used to stick object with another, without a need to be his children.
    // used to keep Background and Gun sticked with the CAM.

    [SerializeField] private Transform cam;
    [SerializeField] private Vector3 offset;

    void FixedUpdate()
    {
        transform.position = new Vector3(cam.position.x+offset.x, cam.position.y+offset.y, offset.z);
    }

}
