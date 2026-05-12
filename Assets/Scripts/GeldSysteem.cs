using UnityEngine;

public class GeldSysteem : MonoBehaviour
{
    [SerializeField] private float _geldValue = 0;

    public float ValueVanGeld(float GeldValue)
    {
        GeldValue = _geldValue;
        return GeldValue;
        
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
