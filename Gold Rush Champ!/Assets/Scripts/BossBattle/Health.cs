using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider slider;

    public void SetHealth(int newHealth)
    {
        slider.value = newHealth;
    }

    public void SetMaxHealth(int maxHealth)
    {
        slider.maxValue = slider.value = maxHealth;
    }
}
