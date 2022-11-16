using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickToScore : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] Text Score;

    float time;

    public void OnPointerClick(PointerEventData eventData)
    {
        Score.text = (Int32.Parse(Score.text) + 1).ToString();
    }

    private void Update()
    {
        time += Time.deltaTime;

        if (time > 2)
        {
            Score.text = (Int32.Parse(Score.text) + 1).ToString();
            time = 0;
        }
    }
}