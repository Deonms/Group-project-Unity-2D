using System;
using UnityEngine;
using TMPro;



// string _bedTag = "Bed";
public class SleepOnBed : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FadeTransition(collision.gameObject);
            print("bed");
        }
    }

    async void FadeTransition(GameObject Player)
    {
        await ScreenFader.Instance.FadeOut();

        await ScreenFader.Instance.FadeIn(); 
    }
}
