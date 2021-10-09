using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Enemy
{
    public float armor;

    public override void TakeDamage(float damage)
    {
        hitPoint -= damage;

        heathBar.SetHealthBar(hitPoint, maxHitPoint);

        if (hitPoint <= 0)
        {
            Die();
        }
    }
}
