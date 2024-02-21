using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 2f;         
    public float movementDistance = 3f; 

    private Vector3 startingPosition;
    private Vector3 direction = Vector3.right + Vector3.forward; // 45 degree direction

    void Start()
    {
        startingPosition = transform.position;
        direction.Normalize(); // Ensure it's a unit vector (length of 1)
    }

    void Update()
    {
        // Calculate target based on 45-degree direction
        Vector3 targetPosition = startingPosition + direction * movementDistance;

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Check if we've reached the target position 
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            direction *= -1; // Reverse direction
        }
    }
}
