using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowPlayer : MonoBehaviour
{
    public GameObject player; // Reference to the player GameObject
    private Vector3 offset = new Vector3(0, 5, -10); // Offset from the player position

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // LateUpdate is called after all Update methods have been called
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
