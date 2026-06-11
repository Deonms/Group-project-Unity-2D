using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GeldSysteem : MonoBehaviour
{
    [SerializeField] private float _geldValue;
    [SerializeField] private TMP_Text _geldText;

    public float GetGeld()
    {
        return _geldValue;
    }
    void Update()
    {
        _geldText.text = "€ " + _geldValue;
    }

    public void GeldErafHalen(float ProductKost)
    {
        _geldValue = _geldValue - ProductKost;
    }
    public void VoegGeldToe(float amount)
    {
        _geldValue = _geldValue + amount;
    }
}
