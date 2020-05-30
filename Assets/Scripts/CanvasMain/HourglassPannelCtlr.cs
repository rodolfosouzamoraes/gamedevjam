using System.Collections;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Classe do painel que mostra a ampulheta com a contagem do tempo
/// </summary>
public class HourglassPannelCtlr : MonoBehaviour
{
    [Header("Texto da contagem do tempo")]
    [SerializeField] Text txtTime;
    [SerializeField] Text txtTimeBack;
    [Header("Imagem da ampulheta")]
    [SerializeField] Image imgHourglass;

    Coroutine coroutine;
    int timeSeconds;

    void Start()
    {
        ActiveOrDesactiveElements(false);
    }
    /// <summary>
    /// Inicia a contagem do tempo no canvas
    /// </summary>
    /// <param name="time">Tempo total</param>
    public void InitTime(int time)
    {
        timeSeconds = time;
        txtTime.text = timeSeconds.ToString();
        txtTimeBack.text = txtTime.text;
        ActiveOrDesactiveElements(true);
        StartScoreTime();
    }
    /// <summary>
    /// Starta a contagem do tempo
    /// </summary>
    private void StartScoreTime()
    {
        if (coroutine != null)
        {
            StopCoroutine(coroutine);
            coroutine = StartCoroutine(UpdateTimeText());
        }
        else
        {
            coroutine = StartCoroutine(UpdateTimeText());
        }
    }
    /// <summary>
    /// Atualiza o texto do tempo
    /// </summary>
    /// <returns></returns>
    IEnumerator UpdateTimeText()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            timeSeconds -= 1;
            if (timeSeconds >= 0)
            {
                txtTime.text = timeSeconds.ToString();
                txtTimeBack.text = txtTime.text;
            }
            else
            {
                StopCoroutine(coroutine);
            }
        }  
    }
    /// <summary>
    /// Ativa ou desativa os elementos do painel
    /// </summary>
    /// <param name="value"></param>
    public void ActiveOrDesactiveElements(bool value)
    {
        txtTime.enabled = value;
        txtTimeBack.enabled = value;
        imgHourglass.enabled = value;
    }
}
