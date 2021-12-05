using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxLight(int light)
    {
        slider.maxValue = light;
        slider.value = light;
    }

    public void SetLight(int light)
    {
        slider.value = light;
    }

}
