using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverPanel;
    [SerializeField] private TMP_Text _scoreText;

    public void ShowGameOver()
    {
        _gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
        _scoreText.text = "Days Survived: " + ScreenFader.Instance.GetDaysPassed();
    }
}
