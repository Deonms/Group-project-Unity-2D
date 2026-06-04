using UnityEngine;

public class GeldSysteem : MonoBehaviour
{
    [SerializeField] private float _geldValue;

    public float GetGeld()
    {
        return _geldValue;
    }

    public void GeldErafHalen(float ProductKost)
    {
        _geldValue = _geldValue - ProductKost;
    }
}
