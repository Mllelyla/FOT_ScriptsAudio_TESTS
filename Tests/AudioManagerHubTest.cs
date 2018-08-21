using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class AudioManagerHubTest : MonoBehaviour

{
    [Header("Back To Menu Button")]
    public AudioButtonTransition BackMenuBtn;
	
    [Header("SFX Uncover Map")]
    [FMODUnity.EventRef]
    public string SFXMapUncover;
    public FMOD.Studio.EventInstance MapSnd;

    [Header("Hub Music")]
    public AudioMusic HubMusic;
    
      /// ----- MAP UNCOVER SFX  -----///
    public void MapUncover()
    {
        //To script with the hub music system in conjunction with the "Hub.cs" script
        MapSnd = FMODUnity.RuntimeManager.CreateInstance(SFXMapUncover);
        MapSnd.start();
    }

    /// ----- MUSIC STOP -----///
    void OnDestroy() //crude alternative while the custom button isnt working
    {
        HubMusic.StopMusicFade();
    }


}
