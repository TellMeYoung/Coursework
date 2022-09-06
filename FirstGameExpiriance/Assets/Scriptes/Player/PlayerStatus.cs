using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour, IDamageable
{
    [Header("Stats")]
    public int maxHealth;
    [HideInInspector]public int curHealth;

    void Start()
    {
        curHealth = maxHealth;
    }

    void Update()
    {

    }

    public void ApplyDamage(int damageValue)
    {
        curHealth -= damageValue;
        Debug.Log("curHeath(" + (curHealth + damageValue) + ")" +
            " - damageValue(" + damageValue + ") =" + curHealth);
        if (curHealth <= 0)
        {
            Debug.Log("Player die");
        }
    }
}
