using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float moveXvalue;
    public float moveZvalue;
    public float rotate;

    void Start()
    {
        moveXvalue = transform.localPosition.x;
        moveZvalue = transform.localPosition.z;
        rotate = transform.localRotation.y;
    }

    void Update()
    {
        moveXvalue = transform.localPosition.x;
        moveZvalue = transform.localPosition.z;
        rotate = transform.localRotation.y;
		
        if (moveXvalue < 0.0f)
        {
            rotate = 90.0f;
        }
        else if (moveXvalue > 0.0f)
        {
           rotate = -90.0f;
        }
		
		
        if (moveZvalue < 0.0f)
        {
            rotate = 180.0f;
        }
        else if (moveZvalue > 0.0f)
        {
			rotate = 0.0f;
        }
    }
}
