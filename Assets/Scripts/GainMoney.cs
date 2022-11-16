using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GainMoney : MonoBehaviour
{
    [SerializeField] private TMP_Text money;
    private float incomeRound;
    bool isTriggerEnter;

    private void AddCash()
    {
        int cash = Int32.Parse(money.text);
        cash++;
        money.text = cash.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        isTriggerEnter = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isTriggerEnter = false;
    }

    void Update()
    {
        incomeRound += Time.deltaTime;
        if ((incomeRound > 2.1f) && (isTriggerEnter))
        {
            AddCash();
            incomeRound = 0;
        }
    }
}