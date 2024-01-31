using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleColor : MonoBehaviour
{
    public Renderer cheeseRenderer;
    public GameObject CheeseOk;
    [SerializeField] private Color[] colors;
    private int colorValue;
    // Start is called before the first frame update
    void Start()
    {
        cheeseRenderer = CheeseOk.GetComponent<Renderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeMaterial()
    {

        colorValue++;
        if (colorValue > 2)
        {
            colorValue = 0;
        }

        cheeseRenderer.material.color = colors[colorValue];

    }
}
