using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public Image hpBar;
    public Image mpBar;
    public Image expBar;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI stageText;

    private int maxHP = 100;
    private int currentHP = 100;
    private int maxMP = 50;
    private int currentMP = 50;
    private int maxExp = 100;
    private int currentExp = 0;
    private int gold = 0;
    private int stage = 1;

    void Start()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        hpBar.fillAmount = (float)currentHP / maxHP;
        mpBar.fillAmount = (float)currentMP / maxMP;
        expBar.fillAmount = (float)currentExp / maxExp;
    }

    public void TakeDamage(int damage)
    {
        currentHP -= damage;
        if (currentHP < 0) currentHP = 0;
        UpdateUI();
    }

    public void UseMana(int amount)
    {
        currentMP -= amount;
        if (currentMP < 0) currentMP = 0;
        UpdateUI();
    }

    public void GainExp(int amount)
    {
        currentExp += amount;
        if (currentExp >= maxExp)
        {
            currentExp = 0;
            stage++; // 레벨업 또는 스테이지 증가
        }
        UpdateUI();
    }
}