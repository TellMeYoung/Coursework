using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDefaultAttack : MonoBehaviour
{
    [SerializeField] private Mimic mimic;
    private float baseAttackSpeed;
    private float curTimeBtwAttack;
    private int attackDmg;
    void Start()
    {
        attackDmg = mimic.attackDamage;
        baseAttackSpeed = mimic.attackSpeed;
        curTimeBtwAttack = baseAttackSpeed;
    }

    private void OnTriggerStay2D(Collider2D hitInfo)
    {
        if (hitInfo.CompareTag("Player"))
        {
            if (curTimeBtwAttack<=0) 
            {
                hitInfo.gameObject.TryGetComponent(out IDamageable damageable);
                damageable.ApplyDamage(attackDmg);
                curTimeBtwAttack = baseAttackSpeed;
            } else
            {
                curTimeBtwAttack -= Time.deltaTime;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D hitInfo)
    {
        curTimeBtwAttack = baseAttackSpeed;
    }
}
