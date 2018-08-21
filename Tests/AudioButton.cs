using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AudioButton : MonoBehaviour

{
    public Button Btn;
    [FMODUnity.EventRef]
    public string SFXButton;
    public FMOD.Studio.EventInstance BtnSnd;
	
	void start()
	{
		Btn.onClick.AddListener(BtnSound);
	}

	public void BtnSound()
	{
		BtnSnd = FMODUnity.RuntimeManager.CreateInstance(SFXButton);
		BtnSnd.start();
	}
	
	
}