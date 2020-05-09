using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Classe responsável por gerenciar o canvas Main
/// </summary>
public class CanvasMainMng : MonoBehaviour
{
    public static CanvasMainMng Instance;
    public static HourglassPannelCtlr HourglassPannel;
    public static TimeBarPannelCtlr TimeBarPannel;
    // Start is called before the first frame update
    void Awake()
    {
        if(Instance==null){
            HourglassPannel = FindObjectOfType<HourglassPannelCtlr>();
            TimeBarPannel = FindObjectOfType<TimeBarPannelCtlr>();
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
