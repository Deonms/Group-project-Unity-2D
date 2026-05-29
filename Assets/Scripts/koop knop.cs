using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class koopknop : MonoBehaviour
{
    private GeldSysteem GetGeld;
    private GeldSysteem GeldErafHalen;

    [SerializeField] private GeldSysteem _geld;
    [SerializeField] private float _itemKost;
    [SerializeField] private string _itemNaam;
    [SerializeField] private TMP_Text _text;
    

    void Start()
    {
        _text.text = $"€{_itemKost}  Koop " + _itemNaam;
    }
    public void BuyItem()
    {
        if (_itemKost <= _geld.GetGeld())
        {
            print($"{_itemNaam} gekocht");
            _geld.GeldErafHalen(_itemKost);
        }
        else
        {
            print($"{_itemNaam} kon niet gekocht worden je hebt {_geld} en het kost {_itemKost}");
        }

    }
}