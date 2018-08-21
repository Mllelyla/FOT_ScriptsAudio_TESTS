using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Audio_MainMenu_Test : MonoBehaviour 
{
	public Button playBtn;
	public Button resetBtn;


    [Header("Button SFX")] // (L)
    [FMODUnity.EventRef]
    public string ButtonEvent;
    FMOD.Studio.EventInstance ButtonSnd;

    [Header("Music")] // (L)
    [FMODUnity.EventRef]
    public string MenuMusicEvent;
    FMOD.Studio.EventInstance MenuMusic;

	void Start () 
	{
		playBtn.onClick.AddListener(PlayBtn);

        // --  Start Menu Music -- // (L)
        PlayMusic();
	}
	

	void PlayBtn () 
	{
        // - Button Sound - // (L)
        PlayButtonSnd();

        // - Music Transition towards Hub Music - // (L)
        StopMusicMenu();
	}
    void PlayButtonSnd()
    {
        ButtonSnd = FMODUnity.RuntimeManager.CreateInstance(ButtonEvent);
        ButtonSnd.start();
    }

    void PlayMusic()
    {
        MenuMusic = FMODUnity.RuntimeManager.CreateInstance(MenuMusicEvent);
        MenuMusic.start();
    }

    void StopMusicMenu()
    {
       //MenuMusic = FMODUnity.RuntimeManager.CreateInstance(MenuMusicEvent);
       MenuMusic.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);

    }
}
