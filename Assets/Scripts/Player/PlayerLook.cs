using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] float sensitivity = 100f;
    [SerializeField] Transform playerBody;
    float xRotation = 0f;
    float yRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        MouseLook();
            
    }

    void MouseLook(){
        float mouseX = Input.GetAxis("Mouse X")*sensitivity*Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y")*sensitivity*Time.deltaTime;
        xRotation -=mouseY;
        xRotation = Mathf.Clamp(xRotation,-14f,14f);
        yRotation +=mouseX;
        yRotation = Mathf.Clamp(yRotation,-90f,90f);
        Debug.Log(yRotation);
        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        playerBody.transform.localRotation = Quaternion.Euler(0f,yRotation,0f);
    }
}
