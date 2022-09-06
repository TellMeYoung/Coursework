using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHpBar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Mimic enemy;

    private void Start()
    {
        SetMaxHealth(enemy.maxHealth);
    }

    private void Update()
    {
        SetHealth(enemy.curHealth);
    }

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(int health)
    {

        slider.value = health;
    }
}
