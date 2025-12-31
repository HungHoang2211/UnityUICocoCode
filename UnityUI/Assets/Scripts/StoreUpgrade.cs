using System;
using TMPro;
using UnityEngine;

public class StoreUpgrade : MonoBehaviour
{
    [Header("Components")]
    public TMP_Text priceText;
    public TMP_Text incomeInfoText;

    public int startPrice =15;
    public float upgradePriceMultiplier;
    public float cookiesPerUpgrade = 0.1f;

    int level = 0;

    private void Start()
    {
        UpdateUI();
    }

    void UpdateUI()
    {
        priceText.text = CaculatePrice().ToString();
        incomeInfoText.text = level.ToString() + "x" + cookiesPerUpgrade + "/s";
        // 5 x 0.5/s
    }
    int CaculatePrice()
    {
        int price = Mathf.RoundToInt(startPrice * Mathf.Pow(upgradePriceMultiplier, level));
        return price;
    }
    public float CaculateIncomePerSecond()
    {
        return cookiesPerUpgrade * level;
    }
}
