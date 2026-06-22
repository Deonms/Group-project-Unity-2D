// deze mf breekt alles

using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print("da end screen is loaded in :D");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnRestartClick()
    {
        SceneManager.LoadScene("DecorationScene");
    }

    public void onExitClick()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }
}


