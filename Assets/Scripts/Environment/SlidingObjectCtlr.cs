using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Classe responsável por movimentar o objeto de um lado para o outro
/// </summary>
public class SlidingObjectCtlr : MonoBehaviour
{
    [Header("Posição do destino do objeto")]
    [SerializeField] Vector3 positionEnd;
    [Header("Velocidade de movimentação")]
    [SerializeField] float speedMovimentation;
    [Header("Tempo de espera na posição alcançada")]
    [SerializeField] float timerWait;
    float nextTime = 0;
    Vector3 target;
    Vector3 positionInitial;
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
        if (Time.time > nextTime) {
            if (transform.localPosition != target)
            {
                transform.localPosition = Vector3.MoveTowards(transform.localPosition, target, speedMovimentation * Time.deltaTime*TimeMng.Instance.timeScale);
            }
            else
            {
                nextTime = Time.time + timerWait;
                if (target == positionEnd)
                {
                    target = positionInitial;
                }
                else if (target == positionInitial)
                {
                    target = positionEnd;
                }
            }
            
        }   
    }
}
