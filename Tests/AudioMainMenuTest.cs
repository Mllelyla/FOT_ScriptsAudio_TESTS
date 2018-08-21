using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AudioMainMenuTest : MonoBehaviour
{

    [Header("Button SFX")]
    [FMODUnity.EventRef]
    public string ButtonEvent;
    FMOD.Studio.EventInstance ButtonSnd;

    [Header("Music")] 
    [FMODUnity.EventRef]
    public string MenuMusicEvent;
    FMOD.Studio.EventInstance MenuMusic;

    void Start()
    {
        // -- How to reference the On.Click of PlayBtn from MainMenu ?? -- //
       // MainMenu.playBtn.onClick.AddListener(CuePlay);
        PlayMusic();
  
    }


    void CuePlay()
    {     
        PlayButtonSnd();
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
        // - Stop MenuMusic with FadeOut - // 
        MenuMusic.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
    }
}
