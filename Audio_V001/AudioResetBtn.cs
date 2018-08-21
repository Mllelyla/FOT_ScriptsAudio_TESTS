using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AudioResetBtn : MonoBehaviour {
    
    Button MyButton;

    [Header("Button SFX")]
    [FMODUnity.EventRef]
    public string ButtonEvent;
    FMOD.Studio.EventInstance ButtonSnd;

    void Start()
    {
        Button MyButton = this.GetComponent<Button>();
        MyButton.onClick.AddListener(PlayButtonSnd);
    }

    public void PlayButtonSnd()
    {
        ButtonSnd = FMODUnity.RuntimeManager.CreateInstance(ButtonEvent);
        ButtonSnd.start();

    }

}
