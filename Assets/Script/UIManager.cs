using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Image HpBar;

    [SerializeField]
    private HealthManagerSO HealthManagerSO;

    private void Start()
    {
        ChangeSliderValue(HealthManagerSO.health);
    }

    private void OnEnable()
    {
        HealthManagerSO.healthChangeEvent.AddListener(ChangeSliderValue);
    }

    private void OnDisable()
    {
        HealthManagerSO.healthChangeEvent.RemoveListener(ChangeSliderValue);
    }

    private void ChangeSliderValue(int amount)
    {
        HpBar.fillAmount = ConvertIntoFloat(amount);
    }

    private float ConvertIntoFloat(int amount)
    {
        return (float)amount / 100;
    }
}