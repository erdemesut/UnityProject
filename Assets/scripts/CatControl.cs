using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CatControl : MonoBehaviour
{
    public Animator catAnimator; 
    public Button walkButton;    
    public Button sitButton;     
    public Button meowButton;    
    public Transform catTransform; 
    public AudioSource meowSound;
    public Button nextButton;

    private bool isWalking = false; 
    private float walkSpeed = 0.07f; 

    void Start()
    {
        walkButton.onClick.AddListener(OnWalkButtonPressed);
        sitButton.onClick.AddListener(OnSitButtonPressed);
        meowButton.onClick.AddListener(OnMeowButtonPressed);
        nextButton.onClick.AddListener(OnNextButtonPressed);

        catAnimator.SetBool("isWalking", false);
        catAnimator.SetBool("isSitting", true);
        catAnimator.SetBool("isMeow", false);
    }

    void Update()
    {
        if (isWalking)
        {
            catTransform.Translate(Vector3.forward * walkSpeed * Time.deltaTime);
        }
    }

    void OnWalkButtonPressed()
    {
        isWalking = true;
        catAnimator.SetBool("isWalking", true);
        catAnimator.SetBool("isSitting", false);
        catAnimator.SetBool("isMeow", false);
    }

    void OnSitButtonPressed()
    {
        isWalking = false;
        catAnimator.SetBool("isWalking", false);
        catAnimator.SetBool("isSitting", true);
        catAnimator.SetBool("isMeow", false);
    }

    void OnMeowButtonPressed()
    {
        if (isWalking)
        {
            isWalking = false;
            catAnimator.SetBool("isWalking", false);
            catAnimator.SetBool("isSitting", true);
        }

        meowSound.Play();
        catAnimator.SetTrigger("isMeow");
    }

    void OnNextButtonPressed()
    {
        SceneManager.LoadScene("NewScene");
    }
}
