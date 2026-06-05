using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] private Image _healthFill;
    [SerializeField] private Image _hungerFill;
    [SerializeField] private Image _happinessFill;

    [SerializeField] private Image _moodImage;

    [Header("Mood Sprites")]
    [SerializeField] private Sprite _happy, _neutral, _sad;

    [Header("Stats")]
    [SerializeField] private float _maxHealth = 100f;
    [SerializeField] private float _maxHunger = 100f;
    [SerializeField] private float _maxHappiness = 100f;

    private float _currentHealth;
    private float _currentHunger;
    private float _currentHappiness;

    [Header("Drain Settings")]
    [SerializeField] private float _healthDrain = 5f;
    [SerializeField] private float _hungerDrain = 1f;
    [SerializeField] private float _happinessDrain = 0.25f;

    private void Start()
    {
        _currentHealth = _maxHealth;
        _currentHunger = 80f;
        _currentHappiness = _maxHappiness;
    }

    private void Update()
    {
        DrainHunger();
        DrainHappiness();
        UpdateMood();
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

            _currentHappiness -= _happinessDrain * Time.deltaTime;
            _currentHappiness = Mathf.Clamp(_currentHappiness, 0, _maxHappiness);
        }
    }

    private void DrainHappiness()
    {
        _currentHappiness -= _happinessDrain * Time.deltaTime;
        _currentHappiness = Mathf.Clamp(_currentHappiness, 0, _maxHappiness);

        if (_currentHappiness <= 0)
        {
            _currentHunger -= _hungerDrain * Time.deltaTime;
            _currentHunger = Mathf.Clamp(_currentHunger, 0, _maxHunger);
        }
    }

    private void UpdateMood()
    {
        float happinessPercentage = _currentHappiness / _maxHappiness;

        if (happinessPercentage >= 0.7f)
        {
            _moodImage.sprite = _happy;
        } else if (happinessPercentage >= 0.5f && happinessPercentage < 0.7f)
        {
            _moodImage.sprite = _neutral;
        } else if (happinessPercentage >= 0.2f && happinessPercentage < 0.4f)
        {
            _moodImage.sprite = _sad;
        }
    }

    private void UpdateUI()
    {
        if (_maxHealth > 0)
        {
            _healthFill.fillAmount = _currentHealth / _maxHealth;
        }

        if (_maxHunger > 0)
        {
            _hungerFill.fillAmount = _currentHunger / _maxHunger;
        }

        if (_maxHappiness > 0)
        {
            _happinessFill.fillAmount = _currentHappiness / _maxHappiness;
        }
    }
}
