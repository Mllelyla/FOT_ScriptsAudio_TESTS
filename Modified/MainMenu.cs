using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenu : MonoBehaviour 
{
	[Header("Background Stuff")]
	public List<MoveCloud> cloudsToMove;
	public FadeInOutBoth titleFade;
	public FadeInOutSprite solidBGFade;

	[Header("Reset Button")]
	public Button resetBtn;
	public Image resetBtnImg;
	public TextMeshProUGUI resetBtnTMP;

	[Header("Play Button")]
	public Button playBtn;
	public Image btnImg;
	public TextMeshProUGUI btnTMP;

	[Header("Button Fade Attributes")]
	public bool fadeBtnOut;
	public float fadeSpeed;
	public float btnAlpha;

	[Header("References")]
	public Hub hubScript;

    [Header("Button SFX")] // (L)
    [FMODUnity.EventRef]
    public string ButtonEvent;
    FMOD.Studio.EventInstance ButtonSnd;

    [Header("Music")] // (L)
    [FMODUnity.EventRef]
    public string MenuMusicEvent;
    FMOD.Studio.EventInstance MenuMusic;

    public bool menuReady;

	void Start () 
	{
		playBtn.onClick.AddListener(PlayBtn);

        // --  Start Menu Music -- // (L)
        PlayMusic();
	}
	


	void Update ()
	{
		// -- Fade Buttons Out -- // 
		if (fadeBtnOut)
		{
			if (btnAlpha > 0) 
			{ 
				btnAlpha -= fadeSpeed; 

				// - Play Button Fade Out - //
				btnImg.color = new Color(1, 1, 1, Mathf.SmoothStep(0f, 1f, btnAlpha));
				btnTMP.color = new Color(0.03f, 0.03f, 0.03f, Mathf.SmoothStep(0f, 1f, btnAlpha));

				// - Reset Button Fade Out - //
				resetBtnImg.color = new Color(1, 1, 1, Mathf.SmoothStep(0f, 1f, btnAlpha));
				resetBtnTMP.color = new Color(0.03f, 0.03f, 0.03f, Mathf.SmoothStep(0f, 1f, btnAlpha));

				if (btnAlpha <= 0)
				{
					playBtn.enabled = false;
					resetBtn.enabled = false;
					fadeBtnOut = false;
				}
			}
		}

		// - Check If I Can Interact With The Menu - //


	}


	void PlayBtn () 
	{
		// - MAKE THE CLOUDS PART - //
		foreach(MoveCloud cloud in cloudsToMove)
		{
			cloud.moveOut = true;
		}

		// - FADE OUT TITLE - //
		titleFade.FadeOut();

		// - FADE OUT SOLID BACKGROUND - //
		solidBGFade.FadeOut();

		// - FADE OUT ALL MENU BUTTONS - //
		fadeBtnOut = true;

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
