using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    public int maxHealth;
    [HideInInspector] public int curHealth;
    public int attackDamage;
    public float attackSpeed;
    public float attackRange;

    public void ApplyDamage(int damageValue)
    {
        curHealth -= damageValue;
        Debug.Log("curHeath(" + (curHealth + damageValue) + ")" +
            " - damageValue(" + damageValue + ") =" + curHealth);
        if (curHealth <= 0)
        {
            Destroy(transform.parent.gameObject);
        }
    }
}
