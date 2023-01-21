using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Slider _healthBar;

    void Update()
    {
        _healthBar.value = Mathf.MoveTowards(_healthBar.value, _player.Health, 0.1f);
    }
}
