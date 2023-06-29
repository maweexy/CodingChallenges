using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickMultiply : MonoBehaviour
{
    public ClickableObj clickObject;
    private Renderer rend;
    public GameObject Instance;
    public Color setColor;
    public Transform parentObj;
    public int numberObjects;

    void Start()
    {
       rend = clickObject.GetComponent<Renderer>();
    }

    void Update()
    {
        if (clickObject.isClicked == true)
        {
            rend.material.color = setColor;
            GameObject newGameObject = Instantiate(Instance, parentObj);
        }
    }

}
