using UnityEngine;

public class GeldSysteem : MonoBehaviour
{
    [SerializeField] private float _geldValue = 0;

    public float GetGeld()
    {
        return _geldValue;
    }

    public void GeldErafHalen(float ProductKost)
    {
        _geldValue = _geldValue - ProductKost;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
