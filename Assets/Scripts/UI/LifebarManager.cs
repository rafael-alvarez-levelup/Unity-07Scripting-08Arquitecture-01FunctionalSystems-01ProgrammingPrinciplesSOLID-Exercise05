﻿using UnityEngine;
using UnityEngine.UI;

public class LifebarManager : MonoBehaviour
{
    [SerializeField] private Image fillImage;

    public void UpdateLifebar(int currentHealth, int maxHealth)
    {
        fillImage.fillAmount = (float)currentHealth / maxHealth;
    }
}