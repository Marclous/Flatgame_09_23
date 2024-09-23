using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI; // Required for UI components

public class UpdateUIText : MonoBehaviour
{
    public TextMeshPro uiText;  // Reference to the Text component
    public String displayText = "Hello!";
    void Start()
    {
        // Set initial text
        uiText.text = "";
    }

    void Update()
    {
        // Update the text dynamically (for example, a score)
        // uiText.text = "Score: " + scoreValue;

    }
    void OnTriggerEnter2D(Collider2D collider) {
        if(collider.gameObject.name == "Player") {
            UpdateText();
        }
    }

    void OnTriggerExit2D(Collider2D collider) {
        uiText.text = "";
    }
    public void UpdateText()
    {
        // Call this function to update the text
        uiText.text = displayText;
    }
}
