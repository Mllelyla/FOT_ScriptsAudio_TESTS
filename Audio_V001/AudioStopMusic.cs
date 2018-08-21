using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AudioStopMusic : MonoBehaviour
{
    public MainMenu Mainscript;
	public Button BtnPlay;
	public AudioBtnSnd BtnSnd;

    [Header("Music")]
    [FMODUnity.EventRef]
    public string MusicEvent;
    FMOD.Studio.EventInstance SceneMusic;

    void Start ()
    {
	
    }
	
	void update()
	{
		if(BtnPlay.enabled)
		{
			 Debug.Log("Bouton Play");
			 
			 StopMusicFade();
			 BtnSnd.PlayButtonSnd();
		}
	}


    void StopMusicFade()
    {
        Debug.Log("Music Stop and slow fade");
        SceneMusic.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }


}
