using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObj : MonoBehaviour
{ 
    public bool isClicked;
    public void OnMouseDown()
    {
        isClicked = true;
        Debug.Log("I got pinched!");
    }
}
