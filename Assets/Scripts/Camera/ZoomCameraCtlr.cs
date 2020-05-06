using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Classe responsável por aplicar o zoom na camera
/// </summary>
public class ZoomCameraCtlr : MonoBehaviour
{
    [Header("Zoom Máximo")]
    [SerializeField] float maxZoom;
    [Header("Zoom Minimo")]
    [SerializeField] float minZoom;
    [Header("Velocidade do Zoom")]
    [SerializeField] float speedZoom;
    float zoomCamera;
    float zoomCameraOriginal;
    void Start()
    {
        zoomCamera = Camera.main.fieldOfView;
        zoomCameraOriginal = zoomCamera;
    }
    void Update()
    {
        CheckInputZoom();
    }
    /// <summary>
    /// Checa qual input do usuário foi precionado para efetuar o zoom
    /// </summary>
    public void CheckInputZoom(){
        if (Input.mouseScrollDelta.y > 0)
        {
            zoomCamera += Camera.main.fieldOfView * Time.deltaTime * speedZoom;
            Zoom();
        }
        else if (Input.mouseScrollDelta.y < 0)
        {
            zoomCamera -= Camera.main.fieldOfView * Time.deltaTime * speedZoom;
            Zoom();
        }
        else if (Input.GetKey (KeyCode.Mouse2))
        {
            zoomCamera = zoomCameraOriginal;
            Camera.main.fieldOfView = zoomCamera;
        }
    }
    /// <summary>
    /// Aplica o zoom na camera
    /// </summary>
    void Zoom(){
        zoomCamera = Mathf.Clamp(zoomCamera, minZoom, maxZoom);
        Camera.main.fieldOfView = zoomCamera;
    }
}
