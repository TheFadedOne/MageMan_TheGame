using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateHP : MonoBehaviour
{
    [SerializeField] Slider slider;

    public void setHealth(int value)
    {
        slider.value = value;
    }
}