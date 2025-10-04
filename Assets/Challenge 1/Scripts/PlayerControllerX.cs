using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 5;
    public float rotationSpeed;
    public float verticalInput;

    // Reference to InGameMenuHandler for pause state
    private InGameMenuHandler menuHandler;

    // Start is called before the first frame update
    void Start()
    {
        // Find InGameMenuHandler for pause state checking
        menuHandler = FindObjectOfType<InGameMenuHandler>();
    }

    void FixedUpdate()
    {
        // Check pause state from InGameMenuHandler only
        bool gamePaused = (menuHandler != null && menuHandler.isPaused);

        // Only allow movement when not paused
        if (!gamePaused)
        {
            // get the user's vertical input
            verticalInput = Input.GetAxis("Vertical");

            // move the plane forward at a constant rate
            transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);

            // tilt the plane up/down based on up/down arrow keys
            transform.Rotate(Vector3.left * rotationSpeed * Time.fixedDeltaTime * verticalInput);
        }
    }
}
