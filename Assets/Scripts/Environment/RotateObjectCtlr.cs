using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjectCtlr : MonoBehaviour
{
    [Header("Velocidade de rotação")]
    [SerializeField] float speed;
    [Header("Eixo a ser rotacionado")]
    [SerializeField] Vector3 axis = new Vector3(1,0,0);
    // Update is called once per frame
    void Update()
    {
        transform.Rotate (axis*speed*Time.deltaTime); 
    }
}
