using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LivingEntity : MonoBehaviour
{
    public string name;

    /// Healbar group
    public float maxHitPoint;
    public float hitPoint;
    public HeathBarController heathBar;


    /// <summary> This func for any Object entity to take damage </summary> 
    public abstract void TakeDamage(float damage);

    public void Die()
    {
        Destroy(gameObject);
    }
}
