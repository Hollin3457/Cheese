using UnityEngine;
using UnityEngine.UI;

public class ToggleCheeseVisibility : MonoBehaviour
{
    public GameObject cheeseObject; // Drag your "Cheese" object here in the Inspector
    private bool isCheeseVisible = true;

    private void Start()
    {
        // Ensure the initial state is set correctly
        cheeseObject.SetActive(isCheeseVisible);
    }

    public void ToggleCheese()
    {
        // is this correct??
        isCheeseVisible = !isCheeseVisible;
        cheeseObject.SetActive(isCheeseVisible);
    }
}

