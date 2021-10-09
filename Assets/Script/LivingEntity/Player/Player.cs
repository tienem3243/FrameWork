using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : LivingEntity
{

    public override void TakeDamage(float damage)
    {
        base.hitPoint -= damage;

        base.heathBar.SetHealthBar(base.hitPoint, base.maxHitPoint);

        if (base.hitPoint <= 0)
        {
            // Dosomething for player die
        }
    }
}
