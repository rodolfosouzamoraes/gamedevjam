using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Classe responsável por realizar o efeito de destaque do botão
/// </summary>
public class HighlightButtonCtlr : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 scaleOriginal;
    
    /// <summary>
    /// Destaca o botão
    /// </summary>
    /// <param name="button">Botão a ser destacado</param>
    public void Highlight(GameObject button){
        scaleOriginal = gameObject.GetComponent<RectTransform>().localScale;
        button.GetComponent<RectTransform>().localScale = new Vector3(scaleOriginal.x*1.2f,scaleOriginal.y*1.2f,scaleOriginal.z*1.2f);
    }

    /// <summary>
    /// Normaliza o botão para a escala original
    /// </summary>
    /// <param name="button">Botão a ser normalizado</param>
    public void Normalize(GameObject button){
        button.GetComponent<RectTransform>().localScale = scaleOriginal;
    }
}
