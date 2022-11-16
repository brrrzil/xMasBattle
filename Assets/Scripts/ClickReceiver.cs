using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ClickReceiver : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject unit;
    [SerializeField] private TMP_Text money;    
    [SerializeField] private Transform[] slots;
    [SerializeField] private int price;
    private int unitIndex = 0, moneyLeft;

    public void OnPointerClick(PointerEventData eventData)
    {
        //Создание нового юнита
        if ((unitIndex < slots.Length) && (price <= System.Int32.Parse(money.text)))
        {
            Instantiate(unit, slots[unitIndex].transform.position, Quaternion.Euler(0, 0, 0));
            unitIndex++;
            moneyLeft = System.Int32.Parse(money.text) - price;
            money.text = moneyLeft.ToString();
        }

        //else Звук полного инвентаря
    }
}