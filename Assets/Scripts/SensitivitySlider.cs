using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensitivitySlider : MonoBehaviour
{
    public static Slider slider;

    // Start is called before the first frame update
    public void Start()
    {
        slider.value = 6f;
    }

    

    // Update is called once per frame
    public void Update()
    {
        if (slider.value == 0f)
        {
            PlayerMovement.sideWaysForce = 5f;
        }
        if (slider.value == 1f)
        {
            PlayerMovement.sideWaysForce = 6f;
        }
        if (slider.value == 2f)
        {
            PlayerMovement.sideWaysForce = 7f;
        }
        if (slider.value == 3f)
        {
            PlayerMovement.sideWaysForce = 8f;
        }
        if (slider.value == 4f)
        {
            PlayerMovement.sideWaysForce = 9f;
        }
        if (slider.value == 5f)
        {
            PlayerMovement.sideWaysForce = 10f;
        }
        if (slider.value == 6f)
        {  
            PlayerMovement.sideWaysForce = 11f;
        }
        if (slider.value == 7f)
        {
            PlayerMovement.sideWaysForce = 12f;
        }
        if (slider.value == 8f)
        {
            PlayerMovement.sideWaysForce = 13f;
        }
        if (slider.value == 9f)
        {
            PlayerMovement.sideWaysForce = 14f;
        }
        if (slider.value == 10f)
        {
            PlayerMovement.sideWaysForce = 15f;
        }
        if (slider.value == 11f)
        {
            PlayerMovement.sideWaysForce = 16f;
        }
        if (slider.value == 12f)
        {
            PlayerMovement.sideWaysForce = 17f;
        } 
    }
}
