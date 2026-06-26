using TMPro;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;

    private void Start()
    {
        _scoreText.text = "Days Survived: " + ScreenFader.DaysPassed;
    }
}
