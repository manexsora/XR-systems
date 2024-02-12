using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light roofLight;
    public InputActionReference action;
    void Start()
    {
        roofLight = GetComponent<Light>();
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            roofLight.color = Color.blue;
        };
    }
}
