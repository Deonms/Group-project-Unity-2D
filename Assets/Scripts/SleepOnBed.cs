using System;
using UnityEngine;
using TMPro;



// string _bedTag = "Bed";
public class SleepOnBed : MonoBehaviour
{


    private float _time = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("the sleeponbed script is loaded in");
    }

    // Update is called once per frame
    void Update()
    {
        _time += Time.deltaTime;
        print(_time);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(_time < 60)
        {
            print("go take a walk");
        } else if (collision.gameObject.CompareTag("Player"))
        {
            _time = 0;
            FadeTransition(collision.gameObject);
        }
    }

    async void FadeTransition(GameObject Player)
    {
        await ScreenFader.Instance.FadeOut();

        await ScreenFader.Instance.FadeIn(); 
    }
}
