using System;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class AreaControl : MonoBehaviour
{
    [SerializeField] private TMP_Text money;
    [SerializeField] private int income, price;
    [SerializeField] private GameObject unit;
    [SerializeField] private Transform[] slots;

    private int currentMoney, unitIndex = 0, moneyLeft;
    private float incomeRound;

    public void OnPointerClick(PointerEventData eventData)
    {
        //Создание нового юнита
        if ((unitIndex < slots.Length) && (price <= Int32.Parse(money.text)))
        {
            Instantiate(unit, slots[unitIndex].transform.position, Quaternion.Euler(0, 0, 0));
            unitIndex++;
            moneyLeft = Int32.Parse(money.text) - price;
            money.text = moneyLeft.ToString();
        }

        //else Звук полного инвентаря
    }

    void Update()
    {
        currentMoney = Int32.Parse(money.text);

        incomeRound += Time.deltaTime;

        if (incomeRound > 2)
        {
            currentMoney += income;
            incomeRound = 0;
        }

        money.text = currentMoney.ToString();
    }
}
