using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour, IPointerClickHandler
{
    public int SceneNumber;

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManager.LoadScene(SceneNumber);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}