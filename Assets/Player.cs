using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Health { get; private set; } = 100;

    private int _maxHealth = 100;
    private int _minHealth = 0;

    public void TakeDamage(int damage)
    {
        Health = Mathf.Clamp(Health - damage, _minHealth, _maxHealth);
    }

    public void Heal(int numberOfHeal)
    {
        Health = Mathf.Clamp(Health + numberOfHeal, _minHealth, _maxHealth);
    }
}
