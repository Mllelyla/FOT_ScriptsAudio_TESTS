using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioPlayMusic : MonoBehaviour
{
    [Header("Play Button")]
    public Button BtnPlay;
    public MainMenu Mainscript;

	public AudioBtnSnd BtnSnd;

    [Header("Music")]
    [FMODUnity.EventRef]
    public string MusicEvent;
    FMOD.Studio.EventInstance SceneMusic;

       void Start()
    {
        PlayMusic();
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

    public void PlayMusic()
    {
        SceneMusic = FMODUnity.RuntimeManager.CreateInstance(MusicEvent);
        SceneMusic.start();
    }
	
    public void StopMusicFade()
    {
        Debug.Log("Music Stop and slow fade");
        SceneMusic.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }



}
