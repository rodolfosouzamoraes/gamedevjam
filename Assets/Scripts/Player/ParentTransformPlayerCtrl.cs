using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Classe responsável por fazer o player se tornar filho do objeto em questão
/// </summary>
public class ParentTransformPlayerCtrl : MonoBehaviour
{
    /// <summary>
    /// Ao entrar em colisão, o player é atribuido como filho do objeto
    /// </summary>
    /// <param name="collision">Corpo colidido</param>
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(transform);
        }
    }
    /// <summary>
    /// Ao Sair da colisão, o player volta a ser filho da cena 
    /// </summary>
    /// <param name="collision">Corpo colidido</param>
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.SetParent(null);
        }
    }
}
