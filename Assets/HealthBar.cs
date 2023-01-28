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

    private bool _isFinished = true;

    private void OnEnable()
    {
        _player.HealthChanged += OnHealthChange;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnHealthChange;
    }

    private void OnHealthChange(int health)
    {
        if (_isFinished)
            StartCoroutine(ChangeValue(health));
    }

    private IEnumerator ChangeValue(int targetValue)
    {
        _isFinished = false;

        while (_healthBar.value != targetValue)
        {
            _healthBar.value = Mathf.MoveTowards(_healthBar.value, targetValue, _fillSpeed * Time.deltaTime);
            yield return null;
        }

        _isFinished = true;
    }
}
