using UnityEngine;

public class RandomColorChanger : MonoBehaviour
{
    public Material[] materials; // Assign the cheese's materials here

    public void ChangeColor()
    {
        Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
        foreach (var material in materials)
        {
            material.color = newColor;
        }
    }
}
