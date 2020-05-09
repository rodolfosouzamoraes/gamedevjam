using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Classe responsável por movimentar o Player
/// </summary>
public class PlayerMoveCtlr : MonoBehaviour
{
    [Header("Velocidade de movimentação")]
    [SerializeField] float moveSpeed;
    [Header("Velocidade de rotação")]
    [SerializeField] float rotateSpeed;

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMng.Instance.RigidbodyPlayer.velocity = new Vector3(0, PlayerMng.Instance.RigidbodyPlayer.velocity.y, 0);
        Move();
    }

    void Move(){
        var vertical = Camera.main.transform.forward * Input.GetAxis("Vertical");
        var horizontal = Camera.main.transform.right * Input.GetAxis("Horizontal");

        vertical.y = 0;

        var direction = horizontal + vertical;

        direction = direction.normalized * moveSpeed * Time.deltaTime;

        if (direction != Vector3.zero) {
            PlayerMng.Instance.RigidbodyPlayer.AddForce(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), rotateSpeed * Time.deltaTime);
            if(PlayerMng.PlayerJump.isGrounded){
                PlayerMng.PlayerAnimation.PlayRun();
            }
            else{
                PlayerMng.PlayerAnimation.PlayFall();
            }
        }
        else{
            if(PlayerMng.PlayerJump.isGrounded){
                PlayerMng.PlayerAnimation.PlayIdle();
            }
            else{
                PlayerMng.PlayerAnimation.PlayFall();
            }
        }
    }
}
