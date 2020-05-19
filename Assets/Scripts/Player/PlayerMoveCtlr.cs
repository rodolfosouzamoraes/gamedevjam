﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Classe responsável por movimentar o Player
/// </summary>
public class PlayerMoveCtlr : MonoBehaviour
{
    [Header("Velocidade de rotação")]
    [SerializeField] float rotateSpeed;
    [Header("Velocidade de movimentação")]
    public float speed = 6.0f;
    [Header("Velocidade de pulo")]
    public float jumpSpeed = 8.0f;
    [Header("Valor da gravidade")]
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;
    private bool isPlayingRunAudio = false;
    CharacterController characterController;
    

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Movimentation();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(!CanvasMainMng.Instance.isEndGame){
            Movimentation();
        }
    }

    void Movimentation(){
        var vertical = Camera.main.transform.forward * Input.GetAxis("Vertical");
        var horizontal = Camera.main.transform.right * Input.GetAxis("Horizontal");

        vertical.y = 0;
        var moveDirectionYBefore = moveDirection.y;
        moveDirection = horizontal + vertical;
        moveDirection *= speed;

        
        if(moveDirection!= Vector3.zero){
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(moveDirection), rotateSpeed * Time.deltaTime);
        }

        moveDirection.y = moveDirectionYBefore;
        if (characterController.isGrounded)
        {
            if(moveDirection.x!= 0 && moveDirection.z!=0){
                PlayerMng.PlayerAnimation.PlayRun();
                if(!isPlayingRunAudio)
                {
                    AudioManager.Instance.Play(Audio.Player, Clip.Run, true);
                    isPlayingRunAudio = true;
                }
            }
            else{
                PlayerMng.PlayerAnimation.PlayIdle();
                AudioManager.Instance.Stop(Audio.Player);
                isPlayingRunAudio = false;
            }
            if (Input.GetButton("Jump"))
            {
                AudioManager.Instance.Play(Audio.Player, Clip.Jump, false);
                isPlayingRunAudio = false;
                moveDirection.y = jumpSpeed;
            }
        }
        else{
            PlayerMng.PlayerAnimation.PlayFall();
        }

        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
