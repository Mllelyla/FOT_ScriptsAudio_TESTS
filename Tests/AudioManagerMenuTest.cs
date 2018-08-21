using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManagerMenuTest : MonoBehaviour
{
    [Header("Play Button")]
	public AudioButtonTransition PlayBtn;

    [Header("Reset Button")]
    public AudioButton BtnReset;

    [Header("Menu Music")]
	public AudioMusic MenuMusic;

    void Start()
    {
        MenuMusic.PlayMusic();
    }
}
