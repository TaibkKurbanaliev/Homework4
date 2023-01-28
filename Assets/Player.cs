using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public int Health { get; private set; } = 100;

    private int _maxHealth = 100;
    private int _minHealth = 0;

    public event UnityAction<int> HealthChanged;

    private void Start()
    {
        HealthChanged?.Invoke(Health);
    }

    public void TakeDamage(int damage)
    {
        Health = Mathf.Clamp(Health - damage, _minHealth, _maxHealth);
        HealthChanged?.Invoke(Health);
    }

    public void Heal(int numberOfHeal)
    {
        Health = Mathf.Clamp(Health + numberOfHeal, _minHealth, _maxHealth);
        HealthChanged?.Invoke(Health);
    }
}
