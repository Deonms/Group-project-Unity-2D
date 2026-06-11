using System;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class HealtOrUnhealthyChecker : MonoBehaviour
{
    [SerializeField] private string _tag;
    [SerializeField] private GeldSysteem _geld;
    [SerializeField] private float _earningsPerCorrect = 1;
    [SerializeField] private string _playerTag = "Player";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == _tag)
        {
            Destroy(collision.gameObject);
            _geld.VoegGeldToe(_earningsPerCorrect);
        }
        else if (collision.gameObject.tag == _playerTag)
        {
            //zorgt ervoor dat het niet gedelete word de speler
        }
        else if (collision.gameObject.tag != _tag)
        {
            Destroy(collision.gameObject);
            _geld.GeldErafHalen(_earningsPerCorrect*5);
        }
    }

}
