using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverUI;
    [SerializeField] private Text _scoreText;

    public void Setup(int score)
    {
        gameObject.SetActive(true);
        _scoreText.text = "Score" + score;
    }
}
