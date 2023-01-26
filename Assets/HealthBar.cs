using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Events;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Slider _healthBar;
    [SerializeField] private float _fillSpeed;

    private void OnEnable()
    {
        _player.OnHealthChange += OnHealthChanged;
    }
    private void OnDisable()
    {
        _player.OnHealthChange -= OnHealthChanged;
    }

    private void OnHealthChanged(int health)
    {
        StartCoroutine(ChangeValue(health));
    }

    private IEnumerator ChangeValue(int targetValue)
    {
        while (_healthBar.value != targetValue)
        {
            _healthBar.value = Mathf.MoveTowards(_healthBar.value, _player.Health, _fillSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
