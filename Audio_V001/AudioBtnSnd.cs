using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AudioBtnSnd : MonoBehaviour {
   
//   public Button MyButton;


    [Header("Button SFX")]
    [FMODUnity.EventRef]
    public string ButtonEvent;
    public FMOD.Studio.EventInstance ButtonSnd;

    void Start ()
    {
       // MyButton = this.GetComponent<Button>();
        //MyButton.onClick.AddListener(PlayButtonSnd);
    }

     public void PlayButtonSnd()
    {
        ButtonSnd = FMODUnity.RuntimeManager.CreateInstance(ButtonEvent);
        ButtonSnd.start();


    }

}
