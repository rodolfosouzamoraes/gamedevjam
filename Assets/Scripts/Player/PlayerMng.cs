using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Classe responsável por gerenciar o Player
/// </summary>
public class PlayerMng : MonoBehaviour
{
    public static  PlayerMng Instance;
    public static PlayerMoveCtlr PlayerMove;
    public static PlayerAnimationCtlr PlayerAnimation;
    void Awake()
    {
        if(Instance==null){
            PlayerMove = GetComponent<PlayerMoveCtlr>();
            PlayerAnimation = GetComponent<PlayerAnimationCtlr>();
            Instance = this;
        }
        else{
            Destroy(gameObject);
        }
    }
    [Header("Rigidbody do player")]
    [SerializeField] Rigidbody rigidbodyPlayer;
    [Header("Transform do Player")]
    [SerializeField] Transform transformPlayer;

    public Rigidbody RigidbodyPlayer{
        get{return rigidbodyPlayer;}
        private set{}
    }
    public Transform TransformPlayer{
        get{return transformPlayer;}
        private set{}
    }
}
