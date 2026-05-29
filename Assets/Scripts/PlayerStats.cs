using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private Image _healthFill;
    [SerializeField] private Image _hungerFill;

    [Header("Stats")]
    [SerializeField] private float _maxHealth = 100f;
    [SerializeField] private float _maxHunger = 100f;

    private float _currentHealth;
    private float _currentHunger;

    [Header("Drain Settings")]
    [SerializeField] private float _healthDrain = 5f;
    [SerializeField] private float _hungerDrain = 1f;

    private void Start()
    {
        _currentHealth = _maxHealth;
        _currentHunger = _maxHunger;
    }

    private void Update()
    {
        DrainHunger();
        UpdateUI();
    }

    private void DrainHunger()
    {
        _currentHunger -= _hungerDrain * Time.deltaTime;

        _currentHunger = Mathf.Clamp(_currentHunger, 0, _maxHunger);

        if (_currentHunger <= 0)
        {
            _currentHealth -= _healthDrain * Time.deltaTime;
            _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);
        }
    }

    private void UpdateUI()
    {
        _healthFill.fillAmount = _currentHealth / _maxHealth;
        _hungerFill.fillAmount = _currentHunger / _maxHunger;
    }
}
