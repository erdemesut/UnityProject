using UnityEngine;
using Vuforia;

public class CatOcclusionInteraction : MonoBehaviour
{
    public Animator catAnimator;
    public AudioSource meowSound;      
    public GameObject catObject;     
    private ObserverBehaviour imageTargetObserver;

    private bool hasMeowed = false;

    void Start()
    {
        imageTargetObserver = GetComponent<ObserverBehaviour>();

        if (imageTargetObserver != null)
        {
            imageTargetObserver.OnTargetStatusChanged += OnTrackingStatusChanged;
        }
    }

    private void OnTrackingStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        if (status.Status != Status.TRACKED && !hasMeowed)
        {
            TriggerMeow();
        }
    }

    private void TriggerMeow()
    {
        catAnimator.SetTrigger("isMeow");

        if (meowSound != null)
        {
            meowSound.Play();
        }

        hasMeowed = true;

        Invoke("ResetMeow", 1.5f);
    }

    private void ResetMeow()
    {
        hasMeowed = false;
    }

    void OnDestroy()
    {
        if (imageTargetObserver != null)
        {
            imageTargetObserver.OnTargetStatusChanged -= OnTrackingStatusChanged;
        }
    }
}
