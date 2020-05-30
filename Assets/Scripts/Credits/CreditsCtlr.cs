using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsCtlr : MonoBehaviour
{
    [SerializeField] GameObject[] credits;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        StartCoroutine(ChangeCredits());
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if(Input.GetButton("Exit")){
            SceneManager.LoadScene(0);
        }
    }

    IEnumerator ChangeCredits(){
        while(true){
            yield return new WaitForSeconds(3f);
            int count = 0;
            foreach(GameObject credit in credits){
                if(credit.activeSelf){
                    credit.SetActive(false);
                    if(count+1> credits.Length-1){
                        count = 0;
                        credits[count].SetActive(true);
                    }
                    else{
                        credits[count+1].SetActive(true);
                    }
                    break;
                }
                count++;
            }
        }
        
    }
}
