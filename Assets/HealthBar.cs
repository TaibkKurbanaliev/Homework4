using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Slider _healthBar;

    private void Update()
    {
        if (_player.Health != _healthBar.value)
        {
            _healthBar.value = Mathf.MoveTowards(_healthBar.value, _player.Health, 0.1f);
        }
    }
}
