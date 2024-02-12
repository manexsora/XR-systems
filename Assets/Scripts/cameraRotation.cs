using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotation : MonoBehaviour
{
    public Camera mainCamera;

    void Update()
    {
        Vector3 lensPosition = transform.position;
        Vector3 cameraPosition = mainCamera.transform.position;

        Vector3 lookDirection = lensPosition - cameraPosition;

        Quaternion finalRotation = Quaternion.LookRotation(lookDirection, transform.parent.parent.up);

        transform.rotation = finalRotation;
    }

}
