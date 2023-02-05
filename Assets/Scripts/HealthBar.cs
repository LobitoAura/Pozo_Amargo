using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;

    void Start()
    {
        slider = GetComponent<Slider>();
    }


    public void ChangeMaxHealth(float maxHealth)
    {
       slider.maxValue = maxHealth;
    }

    public void ChangeCurrentLife(float cantLife)
    {
        slider.value = cantLife;
    }
    public void InitiateLifeBar(float cantLife)
    {
        ChangeMaxHealth(cantLife);
        ChangeCurrentLife(cantLife);

    }
}
