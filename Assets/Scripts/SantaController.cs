using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SantaController : MonoBehaviour
{    
    void Update()
    {
        gameObject.transform.Rotate(0, 0.5f, 0);        
    }
}