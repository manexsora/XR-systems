using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Switchcameras : MonoBehaviour
{
    private Vector3 roomPos = new Vector3(0,1.67f, 1.08f);
    private Quaternion roomRot = new Quaternion(0,180,0,0);
    public Transform externalTransform;  // Set this in the Unity Editor to the external viewing point position
    private bool isInRoom = true;
    public InputActionReference action;


    void Start()
    {
        transform.position = roomPos;
        transform.rotation = roomRot;
        action.action.Enable();
    }
    void Update()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
        if (isInRoom)
            {
                transform.position = externalTransform.position;
                transform.rotation = externalTransform.rotation;
            }
        else
            {
                transform.position = roomPos;
                transform.rotation = roomRot;
            }

        isInRoom = !isInRoom;
        };
    }

}
