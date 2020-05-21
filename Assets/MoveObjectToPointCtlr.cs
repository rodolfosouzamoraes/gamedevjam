using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectToPointCtlr : MonoBehaviour
{
    [Header("Posição do destino do objeto")]
    [SerializeField] Vector3 positionEnd;
    [Header("Velocidade de movimentação")]
    [SerializeField] float speedMovimentation;
    [Header("Tempo de espera na posição alcançada")]
    Vector3 target;
    Vector3 positionInitial;
    bool isActived;
    private void Start()
    {
        positionInitial = transform.localPosition;
        target = positionEnd;
    }
    /// <summary>
    /// Move o objeto da posição inicial a posição final e vice versa
    /// </summary>
    void Update()
    {
        if (isActived) {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, positionEnd, speedMovimentation * Time.deltaTime*TimeMng.Instance.timeScale);
        }
        else {
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, positionInitial, speedMovimentation * Time.deltaTime*TimeMng.Instance.timeScale);
        }   
    }

    public void ActivedOrDesactiveMove(bool v){
        isActived = v;
    }
}
