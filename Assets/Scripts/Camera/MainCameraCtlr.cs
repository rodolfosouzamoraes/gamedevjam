using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Clase responsável por Mover a camera até o player
/// </summary>
public class MainCameraCtlr : MonoBehaviour
{
    float speedRotation;
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        speedRotation = DBMng.MouseSensibility();
    }
    void FixedUpdate()
    {
        if(!CanvasMainMng.Instance.isEndGame){
            transform.position = Vector3.Lerp(transform.position, PlayerMng.Instance.TransformPlayer.position, 5f*Time.deltaTime);
            transform.Rotate(new Vector3(0, Input.GetAxis("Mouse X"), 0) * Time.deltaTime * speedRotation);
        }
    }
}
