using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractionItem : MonoBehaviour
{
    [Header("Evento a ser executado")]
    [SerializeField] UnityEvent TriggerEnter;
    [SerializeField] UnityEvent TriggerExit;

    void OnTriggerStay(Collider other)
    {
        TriggerEnter.Invoke();
    }
    void OnTriggerExit(Collider other)
    {
        TriggerExit.Invoke();
    }
}
