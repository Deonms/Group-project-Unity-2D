using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenFader : MonoBehaviour
{
    private void Start()
    {
        print("the screenfader script is loaded in"); // sjonge jonge deze heeft mij s wat hoofdpijn gegeven, alsjeblieft niks aan veranderen     ~ Amir
    }

    private int _daysPassed = 1;

    public static ScreenFader Instance;
    [SerializeField] CanvasGroup canvasGroup;
    [SerializeField] float fadeDuration = 0.5f;

    private void Awake()
    {
        Debug.Log("ScreenFader Awake");

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    async Task Fade(float targetTransparency)
    {
        float start = canvasGroup.alpha, t = 0;
        while(t < fadeDuration)
        {
            t += Time.deltaTime;
            canvasGroup.alpha = Mathf.Lerp(start, targetTransparency, t / fadeDuration);
            await Task.Yield();
        }
        canvasGroup.alpha = targetTransparency;
    }

    public async Task FadeOut()
    {
        await Fade(1);
        print("zzzzz mimimimi :3");
    }

    public async Task FadeIn()
    {
        await Fade(0);
        print("wakey wakey time for skwool :3");
        PlayerStats.Instance.DaysSurvived++;
        print(_daysPassed);

        if (_daysPassed == 7)
        {
            print("je hebt het een week overleeft, ok nu tijd voor belastingsfraude! :3");

            SceneManager.LoadScene("WinScreen");
        }
    }
}