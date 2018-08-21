using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AudioButtonTransition : MonoBehaviour

{
    public Button Btn;
    [FMODUnity.EventRef]
    public string SFXButton;
    public FMOD.Studio.EventInstance BtnSnd;
	
	[Header("Transition From")]
	public AudioMusic Origin;
	[Header("Transition To")]
	public AudioMusic Destination;
	
	void start()
	{
		Btn.onClick.AddListener(BtnSound);
	}

	public void BtnSound()
	{
		BtnSnd = FMODUnity.RuntimeManager.CreateInstance(SFXButton);
		BtnSnd.start();
		Transition();
	}
	
	    public void Transition()
    {
		Origin.StopMusicFade(); //stop actual music
		Destination.PlayMusic(); //start destination music
    }
}