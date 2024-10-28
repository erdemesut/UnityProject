using UnityEngine;

public class FaceCamera : MonoBehaviour
{
    void Update()
    {
        // Make the text face the camera correctly
        transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.back, Camera.main.transform.rotation * Vector3.up);
    }
}
