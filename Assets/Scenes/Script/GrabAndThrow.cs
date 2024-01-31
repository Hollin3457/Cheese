using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;

public class GrabAndThrow : MonoBehaviour
{
    public Rigidbody CheeseOkRigidbody;
    public float throwForceMultiplier = 10f;

    private Vector3 manipulationStartPos;
    private float manipulationStartTime;

    // This method is automatically called by the ObjectManipulator on manipulation started
    public void OnManipulationStarted()
    {
        manipulationStartPos = transform.position;
        manipulationStartTime = Time.time;
    }

    // This method is automatically called by the ObjectManipulator on manipulation ended
    public void OnManipulationEnded()
    {
        ThrowCheese();
    }

    public void ThrowCheese()
    {
        // Calculate manipulation velocity
        Vector3 manipulationEndPos = transform.position;
        float manipulationDuration = Time.time - manipulationStartTime;
        Vector3 manipulationVelocity = (manipulationEndPos - manipulationStartPos) / manipulationDuration;

        // Calculate throw force based on manipulation velocity
        float throwForce = manipulationVelocity.magnitude * throwForceMultiplier;

        // Apply force to the cheese
        CheeseOkRigidbody.AddForce(Camera.main.transform.forward * throwForce);

        // Add any additional logic after throwing the cheese if needed
    }
}