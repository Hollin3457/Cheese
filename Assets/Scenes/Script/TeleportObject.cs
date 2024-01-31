using UnityEngine;

public class TeleportObject : MonoBehaviour
{
    private Vector3 startingPosition;

    void Start()
    {
        // Store the initial position of the object
        startingPosition = transform.position;
    }

    public void TeleportToStartingPosition()
    {
        // Teleport the object back to its initial position
        transform.position = startingPosition;
    }
}
