using UnityEngine;

public class Doors : MonoBehaviour
{
    [SerializeField] private string _playertag = "Player";
    //dit zegt waar de speler heen moet uiteindelijk:
    [SerializeField] float _teleportToX;
    [SerializeField] float _teleportToY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision) //checkt op collision
    {
        if (collision.gameObject.CompareTag(_playertag)) //checkt of de object die collision met dit krijgt de player tag heeft zo ja dan voet hij dit uit
        {
            Vector3 position = new Vector3(_teleportToX, _teleportToY, -1f); //zet de speler terug waar die heen moet
            collision.gameObject.transform.position = position;
        }

    }
}
