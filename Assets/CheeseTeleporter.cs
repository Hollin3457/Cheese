using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class CheeseTeleporter : MonoBehaviour
{
    public GameObject cheeseObject;  // Assign the CheeseOk object in the Unity Editor
    public float teleportDistance = 1.0f;  // Set the desired teleport distance
    public float temporaryMassMultiplier = 10f;  // Set the multiplier for temporary mass increase

    private float originalMass;

    void Start()
    {
        // Check if the CheeseOk object is assigned
        if (cheeseObject == null)
        {
            Debug.LogError("Cheese object not assigned for teleportation.");
        }
        else
        {
            // Save the original mass of the CheeseOk object
            Rigidbody cheeseRigidbody = cheeseObject.GetComponent<Rigidbody>();
            if (cheeseRigidbody != null)
            {
                originalMass = cheeseRigidbody.mass;
            }
            else
            {
                Debug.LogError("Rigidbody component not found on Cheese object.");
            }
        }
    }

    // Method to be called when the button is clicked
    public void TeleportToCheeseOnClick()
    {
        // Check if the CheeseOk object is assigned
        if (cheeseObject != null)
        {
            // Temporarily increase the mass of the CheeseOk object
            Rigidbody cheeseRigidbody = cheeseObject.GetComponent<Rigidbody>();
            if (cheeseRigidbody != null)
            {
                cheeseRigidbody.mass *= temporaryMassMultiplier;
            }

            // Teleport the CheeseOk object to the exact position of the camera
            Transform mainCameraTransform = Camera.main.transform;

            if (mainCameraTransform != null)
            {
                cheeseObject.transform.position = mainCameraTransform.position + mainCameraTransform.forward * teleportDistance;
            }
            else
            {
                Debug.LogError("Main camera not found for teleportation.");
            }

            // Revert the mass back to its original value
            if (cheeseRigidbody != null)
            {
                cheeseRigidbody.mass = originalMass;
            }
        }
        else
        {
            Debug.LogError("Cheese object not assigned for teleportation.");
        }
    }
}
