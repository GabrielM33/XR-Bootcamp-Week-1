using UnityEngine;
using UnityEngine.UI;

public class TriggerInteraction : MonoBehaviour
{
    public GameObject trophyPrefab;         // Reference to your trophy prefab
    public GameObject textCanvas;           // Reference to a Canvas that holds the UI text
    public Text messageText;                // Reference to the Text component on the canvas

    public string displayMessage = "You Win!"; // The message to display

    private bool hasTriggered = false;      // Flag to prevent triggering multiple times

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;

            // Instantiate Trophy
            if (trophyPrefab) 
            {
                Instantiate(trophyPrefab, transform.position + Vector3.up, Quaternion.identity); 
            }

            // Activate and Display Text
            if (textCanvas)
            {
                textCanvas.SetActive(true);
            }
            if (messageText)
            {
                messageText.text = displayMessage;
            }
        }
    }
}
