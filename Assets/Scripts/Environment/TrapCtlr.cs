using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapCtlr : MonoBehaviour
{
    [Header("Velocidade de queda")]
    [SerializeField] float speedFall;
    bool isActive;
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if(isActive){
            transform.Translate(Vector3.down*Time.deltaTime*speedFall*TimeMng.Instance.timeScale,Space.World);
        }
    }
    void OnCollisionEnter(Collision other)
    {
        if(!isActive){
            if(other.gameObject.CompareTag("Player")){
                isActive = true;
            }
        }
        
    }
}
