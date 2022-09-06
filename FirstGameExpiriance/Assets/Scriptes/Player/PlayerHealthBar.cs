using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
   [SerializeField] private Slider slider;
   [SerializeField] private PlayerStatus playerStatus;

    private void Start()
    {
        SetMaxHealth(playerStatus.maxHealth);
    }

    private void Update()
    {
        SetHealth(playerStatus.curHealth);
    }

    public void SetMaxHealth (int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
      
        slider.value = health;
    }

}
