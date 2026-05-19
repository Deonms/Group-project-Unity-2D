using UnityEngine;
using UnityEngine.UI;
public class NewMonoBehaviourScript : MonoBehaviour
{
    private int _health = 100;

    [SerializeField] private Image _healthImage;

    private void Update()
    {
        _healthImage.fillAmount = _health / 100f;
    }
}
