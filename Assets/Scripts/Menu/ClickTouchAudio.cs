using UnityEngine;

public class ClickTouchAudio : MonoBehaviour
{
    bool isTouch;

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 || Input.GetMouseButtonDown(0)){
            if(!isTouch){
                AudioManager.Instance.Play(Audio.Effect,Clip.Jump,false);
                isTouch = true;
            }
        }
        else{
            isTouch = false;
        }
    }
}
