using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class koopknop : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private GameObject _moetVeranderen;

    private GeldSysteem GetGeld;
    private GeldSysteem GeldErafHalen;

    [SerializeField] private GeldSysteem _geld;
    [SerializeField] private float _itemKost;
    [SerializeField] private string _itemNaam;
    [SerializeField] private TMP_Text _text;
    

    void Start()
    {
        _text.text = "€" + _itemKost + " " + _itemNaam;
    }

    public void BuyItem()
    {
        if (_itemKost <= _geld.GetGeld())
        {
            print($"{_itemNaam} is gekocht");
            _geld.GeldErafHalen(_itemKost);
            _playerStats.SmallHealthIncrease();
            _playerStats.SmallHungerIncrease();
            _playerStats.SmallHappinessIncrease();
            _playerStats.HealthIncrease();
            _playerStats.HungerIncrease();
            _playerStats.HappinessIncrease();
            _playerStats.SmallHealthDecrease();
            _playerStats.SmallHappinessDecrease();
            _playerStats.HealthDecrease();
            _playerStats.HappinessDecrease();
        }
        else
        {
            print($"{_itemNaam} kon niet gekocht worden je hebt {_geld} en het kost {_itemKost}");
        }
    }
}