using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ScriptButtons : MonoBehaviour
{
    //OnPointerDown is also required to receive OnPointerUp callbacks
    public void OnPointerDown(PointerEventData eventData)
    {
		
        Debug.Log("The mouse is clicking");
    }

    //Do this when the mouse click on this selectable UI object is released.
    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("The mouse click was released");
    }
}
