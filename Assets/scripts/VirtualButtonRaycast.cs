using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class VirtualButtonRaycast : MonoBehaviour
{
    public Camera arCamera;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ProcessTouch(Input.mousePosition);
        }

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                ProcessTouch(touch.position);
            }
        }
    }

    private void ProcessTouch(Vector3 screenPosition)
    {
        Ray ray = arCamera.ScreenPointToRay(screenPosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("Raycast hit: " + hit.collider.name);

            Button button = hit.collider.GetComponent<Button>();
            if (button != null)
            {
                Debug.Log("Button found and clicked: " + button.name);
                button.onClick.Invoke();
            }
            else
            {
                Debug.Log("No Button component found on hit object.");
            }
        }
        else
        {
            Debug.Log("Raycast did not hit anything.");
        }
    }
}
