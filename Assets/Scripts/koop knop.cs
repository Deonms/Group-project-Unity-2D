using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class koopknop : MonoBehaviour
{
    [SerializeField] private float geld;
    [SerializeField] private float itemKost;
    [SerializeField] private string itemNaam;
    [SerializeField] private TMP_Text text;

    void Start()
    {
        text.text = "Koop " + itemNaam;
    }
    public void BuyItem()
    {
        if (itemKost <= geld)
        {
            print($"{itemNaam} gekocht");
            geld = geld - itemKost;
        }
        else if (itemKost > geld)
        {
            print($"{itemNaam} kon niet gekocht worden je hebt {geld} en het kost {itemKost}");
        }

    }
}