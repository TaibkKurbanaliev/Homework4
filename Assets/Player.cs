using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Health { get; private set; } = 100;

    private int _maxHealth = 100;

    public void TakeDamage(int damage)
    {
        if (Health - damage >= 0)
        {
            Health -= damage;
        }
    }

    public void Heal(int numberOfHeal)
    {
        if (Health + numberOfHeal <= _maxHealth)
        {
            Health += numberOfHeal;
        }
    }
}
