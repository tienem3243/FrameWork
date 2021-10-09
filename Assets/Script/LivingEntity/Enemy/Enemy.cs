using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : LivingEntity
{
    /// <summary> make healbar display </summary> 
    private void Start()
    {
        heathBar.SetHealthBar(hitPoint, maxHitPoint);
    }

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
