using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplyObject : MonoBehaviour
{
    public GameObject burgerObject;
    public Transform burgerParent;

    public float stackOffset;
    public float incrementVal;
  
    void Update()
    {
        

        if (Input.GetMouseButtonDown(0))
        {
            Vector3 spawnPos = burgerParent.position + new Vector3(0,incrementVal,0)*++stackOffset;
            GameObject newObject = Instantiate(burgerObject, spawnPos, Quaternion.identity, burgerParent);
        }
        if (burgerParent.childCount != 0) {
            if (Input.GetMouseButtonDown(1))
            {
                var childAmount = burgerParent.childCount;
                var oldestChild = burgerParent.GetChild(childAmount-1);
                Destroy(oldestChild.gameObject);
                stackOffset--;
            }
        }    
    }
}
