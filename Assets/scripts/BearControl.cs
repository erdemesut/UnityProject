using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BearControl : MonoBehaviour
{
    public Animator bearAnimator;
    public Button runButton;
    public Button sitButton;
    public Button sleepButton;
    public Button jumpButton;
    public Button nextButton;


    void Start()
    {
        runButton.onClick.AddListener(OnRunButtonPressed);
        sitButton.onClick.AddListener(OnSitButtonPressed);
        sleepButton.onClick.AddListener(OnSleepButtonPressed);
        jumpButton.onClick.AddListener(OnJumpButtonPressed);
        nextButton.onClick.AddListener(OnNextButtonPressed);

    }

    void Update()
    {

    }

    void OnRunButtonPressed()
    {
        bearAnimator.SetTrigger("RUN");
    }

    void OnSitButtonPressed()
    {
        bearAnimator.SetTrigger("SIT");
    }

    void OnSleepButtonPressed()
    {
        bearAnimator.SetTrigger("SLEEP");
    }

    void OnJumpButtonPressed()
    {
        bearAnimator.SetTrigger("JUMP");
    }

    void OnNextButtonPressed()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
