using UnityEngine;

public class Moving1 : MonoBehaviour
{
    public float speed = 2f;         // Movement speed
    public float movementDistance = 3f; // Distance to travel in each direction
    public bool startMovingRight = true; // Start moving right initially

    private Vector3 startingPosition;
    private bool movingRight = true; 

    void Start()
    {
        startingPosition = transform.position;
        movingRight = startMovingRight;
    }

    void Update()
    {
        Vector3 targetPosition = startingPosition + (movingRight ? Vector3.right : Vector3.left) * movementDistance;

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Check if we've reached the target position
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            movingRight = !movingRight;  // Switch directions
        }
    }
}
