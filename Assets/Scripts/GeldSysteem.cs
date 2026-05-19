using UnityEngine;

public class GeldSysteem : MonoBehaviour
{
    [SerializeField] private float _geldValue = 10;

    public float GetGeld()
    {
        return _geldValue;
    }

    public void GeldErafHalen(float ProductKost)
    {
        _geldValue = _geldValue - ProductKost;
    }
}
