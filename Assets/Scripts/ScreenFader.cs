using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;

public class ScreenFader : MonoBehaviour
{

    private int _daysPassed = 1;

    private void Start()
    {
        print("screenfader script loaded in");
    }

    public static ScreenFader Instance;
    [SerializeField] CanvasGroup canvasGroup;
    [SerializeField] float fadeDuration = 0.5f;

    private void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
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
        _daysPassed++;
    }

    If (_daysPassed >= 7)
    {
        print("je hebt het een week overleeft, ok nu tijd voor belastingsfraude!");
    }
}