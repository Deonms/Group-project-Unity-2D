using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private GameOver _gameOver;

    [Header("UI")]
    [SerializeField] private Image _healthFill;
    [SerializeField] private Image _hungerFill;
    [SerializeField] private Image _happinessFill;

    [SerializeField] private Image _moodImage;

    [Header("Mood Sprites")]
    [SerializeField] private Sprite _happy, _neutral, _sad, _cry;

    [Header("Stats")]
    [SerializeField] private float _maxHealth = 100f;
    [SerializeField] private float _maxHunger = 100f;
    [SerializeField] private float _maxHappiness = 100f;

    public float _currentHealth;
    public float _currentHunger;
    public float _currentHappiness;

    [Header("Drain Settings")]
    [SerializeField] private float _healthDrain;
    [SerializeField] private float _hungerDrain;
    [SerializeField] private float _happinessDrain;

    [Header("Change Settings")]
    [SerializeField] private float _changeHealth;
    [SerializeField] private float _changeHunger;
    [SerializeField] private float _changeHappiness;

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

    public void SmallHealthIncrease(float amount)
    {
        _currentHealth += amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);
    }
    
    public void HealthIncrease(float amount)
    {
        _currentHealth += amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);
    }

    public void SmallHungerIncrease(float amount)
    {
        _currentHunger += amount;
        _currentHunger = Mathf.Clamp(_currentHunger, 0, _maxHunger);
    }

    public void HungerIncrease(float amount)
    {
        _currentHunger += amount;
        _currentHunger = Mathf.Clamp(_currentHunger, 0, _maxHunger);
    }

    public void SmallHappinessIncrease(float amount)
    {
        _currentHappiness += amount;
        _currentHappiness = Mathf.Clamp(_currentHappiness, 0, _maxHappiness);
    }

    public void HappinessIncrease(float amount)
    {
        _currentHappiness += amount;
        _currentHappiness = Mathf.Clamp(_currentHappiness, 0, _maxHappiness);
    }

    public void SmallHealthDecrease(float amount)
    {
        _currentHealth -= amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);
    }

    public void HealthDecrease(float amount)
    {
        _currentHealth -= amount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, _maxHealth);
    }

    public void SmallHappinessDecrease(float amount)
    {
        _currentHappiness -= amount;
        _currentHappiness = Mathf.Clamp(_currentHappiness, 0, _maxHappiness);
    }

    public void HappinessDecrease(float amount)
    {
        _currentHappiness -= amount;
        _currentHappiness = Mathf.Clamp(_currentHappiness, 0, _maxHappiness);
    }

    private void UpdateMood()
    {
        if (_moodImage == null)
            return;

        float happinessPercentage = _currentHappiness / _maxHappiness;

        if (happinessPercentage >= 0.75f)
        {
            _moodImage.sprite = _happy;
        } else if (happinessPercentage >= 0.4f && happinessPercentage < 0.75f)
        {
            _moodImage.sprite = _neutral;
        } else if (happinessPercentage >= 0.2f && happinessPercentage < 0.4f)
        {
            _moodImage.sprite = _sad;
        } else
        {
            _moodImage.sprite = _cry;
        }
    }

    private void UpdateUI()
    {
        if (_maxHealth > 0)
        {
            if (_healthFill != null)
            {
                _healthFill.fillAmount = _currentHealth / _maxHealth;
            }
        }

        if (_maxHunger > 0)
        {
            if (_hungerFill != null)
            {
                _hungerFill.fillAmount = _currentHunger / _maxHunger;
            }
        }

        if (_maxHappiness > 0)
        {
            if (_happinessFill != null)
            {
                _happinessFill.fillAmount = _currentHappiness / _maxHappiness;
            }
        }

        if (_currentHealth > _maxHealth)
        {
            _currentHealth = _maxHealth;
        }

        if (_currentHappiness > _maxHappiness)
        {
            _currentHappiness = _maxHappiness;
        }

        if (_currentHealth <= 0)
        {
            _gameOver.ShowGameOver();
        }
    }
}
