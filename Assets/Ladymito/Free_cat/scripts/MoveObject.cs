using UnityEngine;

public class MoveObject : MonoBehaviour
{
    // Speed of movement
    public float speed = 1.0f;

    // Distance the object moves
    public float distance = 2.0f;

    // Initial position of the object
    private Vector3 startPosition;

    void Start()
    {
        // Store the initial position of the object
        startPosition = transform.localPosition;
    }

    void Update()
    {
        // Calculate new position based on time, speed, and distance
        float move = Mathf.PingPong(Time.time * speed, distance);
        transform.localPosition = startPosition + new Vector3(0, 0, move);
    }
}
