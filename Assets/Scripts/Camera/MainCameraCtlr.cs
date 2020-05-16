using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Clase responsável por Mover a camera até o player
/// </summary>
public class MainCameraCtlr : MonoBehaviour
{
    [Header("Velocidade de rotação")]
    [SerializeField] float speedRotation;
    void FixedUpdate()
    {
        if(!CanvasMainMng.Instance.isEndGame){
            transform.position = Vector3.Lerp(transform.position, PlayerMng.Instance.TransformPlayer.position, 5f*Time.deltaTime);
            transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * Time.deltaTime * speedRotation);
        }
    }
}
