using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class cameraController : MonoBehaviour
{
    ControllerInput controls;

    public float mouseSensitivity = 300f;
    public Transform playerBody;

    float xRotation = 0f;

    Vector2 cameraInput;

    void Awake()
    {
        controls = new ControllerInput();
        controls.Gameplay.Camera.performed += ctx => cameraInput = ctx.ReadValue<Vector2>();
        controls.Gameplay.Camera.canceled += ctx => cameraInput = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(cameraInput);
        float mouseX = cameraInput.x * mouseSensitivity * Time.deltaTime;
        float mouseY = cameraInput.y * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
