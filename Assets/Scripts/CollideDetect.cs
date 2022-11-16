using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideDetect : MonoBehaviour
{
    public GameObject buyButton;
    private bool canBuy;

    private void OnTriggerEnter(Collider other)
    {
        canBuy = true;
    }

    private void OnTriggerExit(Collider other)
    {
        canBuy = false;
    }

    private void Update()
    {
        if (canBuy) buyButton.SetActive(true);
        else buyButton.SetActive(false);
    }
}