using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxAir(int air)
    {
        slider.maxValue = air;
        slider.value = air;
    }

    public void SetAir(int air)
    {
        slider.value = air;
    }

}
