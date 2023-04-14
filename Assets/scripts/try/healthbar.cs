using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class healthbar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image filll;


    public void setmaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
        filll.color = gradient.Evaluate(1f);


    }

    // Update is called once per frame
    public void setHealth(int health)
    {
        slider.value = health;

        filll.color = gradient.Evaluate(slider.normalizedValue);
    }
}
