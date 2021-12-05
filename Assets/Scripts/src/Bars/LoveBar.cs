using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoveBar : MonoBehaviour
{

    public Slider slider;

    public void SetMaxLove(int love)
    {
        slider.maxValue = love;
        slider.value = love;
    }

    public void SetLove(int love)
    {
        slider.value = love;
    }

}
