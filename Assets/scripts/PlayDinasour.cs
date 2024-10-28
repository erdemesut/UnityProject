using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayDinasour : MonoBehaviour
{
    public Animator dinoAnimator;
    public Button playButton;
    public Button nextSceneButton;
    public Transform dinoTransform;

    private bool isPlaying = false;

    void Start()
    {
        playButton.onClick.AddListener(OnPlayButtonPressed);
        nextSceneButton.onClick.AddListener(OnNextSceneButtonPressed);

        dinoAnimator.SetBool("isPlaying", false);
    }

    void Update()
    {
        
    }

    void OnPlayButtonPressed()
    {
        if (!isPlaying)
        {
            dinoAnimator.SetBool("isPlaying", true);
            isPlaying = true;
        }
        else
        {
            dinoAnimator.SetBool("isPlaying", false);
            isPlaying = false;
        }
    }

    void OnNextSceneButtonPressed()
    {
        SceneManager.LoadScene("LastScene");
    }
}
