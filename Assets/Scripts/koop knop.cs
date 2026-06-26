using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class koopknop : MonoBehaviour
{
    [SerializeField] private ShopItem _item;
    [SerializeField] private PlayerStats _playerStats;

    private GeldSysteem _getGeld;
    private GeldSysteem _geldErafHalen;

    [SerializeField] private GeldSysteem _geld;
    [SerializeField] private TMP_Text _text;

    void Start()
    {
        _text.text = "€" + _item.ItemKost + " " + _item.ItemNaam;
    }

    public void BuyItem()
    {
        if (_item.ItemKost <= _geld.GetGeld())
        {
            print($"{_item.ItemNaam} is gekocht");
            _geld.GeldErafHalen(_item.ItemKost);
        }
        else
        {
            print($"{_item.ItemNaam} kon niet gekocht worden je hebt {_geld} en het kost {_item.ItemKost}");
        }
    }

    public void BuyFood()
    {
        if (_item.BuyItem())
        {
            _playerStats.HungerIncrease(10);
        }
    }

    public void BuyHealthy()
    {
        if (_item.BuyItem())
        {
            _playerStats.HealthIncrease(10);
        }
    }

    public void BuyHappy()
    {
        if (_item.BuyItem())
        {
            _playerStats.HappinessIncrease(10);
        }
    }

    public void BuySmallFood()
    {
        if (_item.BuyItem())
        {
            _playerStats.SmallHungerIncrease(5);
        }
    }

    public void BuySmallHealthy()
    {
        if (_item.BuyItem())
        {
            _playerStats.SmallHealthIncrease(5);
        }
    }

    public void BuySmallHappy()
    {
        if (_item.BuyItem())
        {
            _playerStats.SmallHappinessIncrease(5);
        }
    }

    public void BuyUnhealthy()
    {
        if (_item.BuyItem())
        {
            _playerStats.HealthDecrease(10);
        }
    }

    public void BuyUnhappy()
    {
        if (_item.BuyItem())
        {
            _playerStats.HappinessDecrease(10);
        }
    }

    public void BuySmallUnhealthy()
    {
        if (_item.BuyItem())
        {
            _playerStats.SmallHealthDecrease(5);
        }
    }

    public void BuySmallUnhappy()
    {
        if (_item.BuyItem())
        {
            _playerStats.SmallHappinessDecrease(5);
        }
    }
}