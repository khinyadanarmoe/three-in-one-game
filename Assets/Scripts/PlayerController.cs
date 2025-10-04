
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float speed = 10;
    public float turnSpeed = 5;
    public float horizontalInput;
    public float forwardInput;

    // Reference to InGameMenuHandler for pause state
    private InGameMenuHandler menuHandler;

    // Start is called before the first frame update
    void Start()
    {
        // Find InGameMenuHandler for pause state checking
        menuHandler = FindObjectOfType<InGameMenuHandler>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check pause state from InGameMenuHandler
        bool gamePaused = (menuHandler != null && menuHandler.isPaused);

        // Only allow movement when not paused
        if (!gamePaused)
        {
            horizontalInput = Input.GetAxis("Horizontal");
            forwardInput = Input.GetAxis("Vertical");
            // transform.Translate(0,0,1);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
            transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        }
    }
}
