using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void ShowGameOver()
    {
        SceneManager.LoadScene("GameOverScene");
    }
}