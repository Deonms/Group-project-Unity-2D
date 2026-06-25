using System;
using TMPro;
using UnityEngine;
using static UnityEditor.Progress;

public class ShopItem : MonoBehaviour
{
    [SerializeField] private string _itemNaam;
    [SerializeField] private float _itemKost;
    [SerializeField] private GeldSysteem _geld;

    public string ItemNaam => _itemNaam;
    public float ItemKost => _itemKost;

    public bool BuyItem()
    {
        if (_itemKost <= _geld.GetGeld())
        {
            print($"{_itemNaam} is gekocht");
            _geld.GeldErafHalen(_itemKost);
            return true;
        }

        print($"{_itemNaam} kon niet gekocht worden je hebt {_geld} en het kost {_itemKost}");
        return false;
    }
}
