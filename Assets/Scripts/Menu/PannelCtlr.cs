using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Classe responsável por comparar o painel a ser habilitado
/// </summary>
public class PannelCtlr : MonoBehaviour
{
    /// <summary>
    /// Compara o painel solicitado com o painel atual
    /// </summary>
    /// <param name="pannel">Painel a ser solicitado para habilitar</param>
    /// <returns>Retorna verdadeiro ou falso</returns>
    public bool Compare(PannelCtlr pannel) {
        return pannel.name.ToLower() == name.ToLower();
    }
}
