using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirtBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxDirt(int dirt)
    {
        slider.maxValue = dirt;
        slider.value = dirt;
    }

    public void SetDirt(int dirt)
    {
        slider.value = dirt;
    }

}
