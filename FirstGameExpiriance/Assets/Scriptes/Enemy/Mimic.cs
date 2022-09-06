using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mimic : Enemy
{
    [SerializeField] private CircleCollider2D circleCollider2D;
    void Start()
    {
        curHealth = maxHealth;
        circleCollider2D.radius = attackRange;

    }
}
