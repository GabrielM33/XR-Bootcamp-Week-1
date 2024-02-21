using UnityEngine;

public class PlayerReset : MonoBehaviour
{
    public Transform resetPosition; // Where to reset the player
    public string fallTriggerTag = "FallZone"; // Tag for objects that trigger a fall

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(fallTriggerTag))
        {
            ResetPlayer();
        }
    }

    void ResetPlayer() 
    {
        // Assuming your player is the object this script is attached to
        transform.position = resetPosition.position; 

        // Optionally reset player's velocity
        Rigidbody playerRigidbody = GetComponent<Rigidbody>();
        if (playerRigidbody)
        {
            playerRigidbody.velocity = Vector3.zero;
            playerRigidbody.angularVelocity = Vector3.zero;
        }
    }
}
