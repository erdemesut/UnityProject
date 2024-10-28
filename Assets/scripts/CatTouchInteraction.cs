using UnityEngine;

public class CatTouchInteraction : MonoBehaviour
{
    public Animator catAnimator; 
    public AudioSource meowSound; 

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject == gameObject) 
                    {
                        catAnimator.SetTrigger("isMeow");
                        meowSound.Play();
                    }
                }
            }
        }
    }
}
