using UnityEngine;

public class RotatingMoon : MonoBehaviour
{
    public float rotationSpeed = 10f; 

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}