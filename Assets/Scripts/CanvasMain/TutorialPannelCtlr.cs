using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialPannelCtlr : MonoBehaviour
{
    [SerializeField] Text txtMessage;
    [SerializeField] Text txtMessageBack;

    public void SetMessage(string message){
        txtMessage.text = message;
        txtMessageBack.text = message;
    }
}
