using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionItem : MonoBehaviour
{
    public Vector3 initialPos;
    public ItemCollector ItemCollector;
    public float duration = 1.0f;
    public float elapsedTime = 0.0f;
    public bool isCollected;
    public bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.localPosition;
        isCollected = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isClicked == true)
        {
            elapsedTime += Time.deltaTime;
            float t = Mathf.Clamp01(elapsedTime/duration);
            transform.localPosition = Vector3.Lerp(initialPos, ItemCollector.targetPos, t);

            if(t >= 1.0f)
            {
                for (int i = 0; i < transform.childCount; i++)
                {
                    var childTransform = transform.GetChild(i);
                    childTransform.gameObject.SetActive(false);
                }
                isCollected = true;
            }
        }
        else
        {
            transform.localPosition = initialPos;
            elapsedTime = 0.0f;
            for (int i = 0; i < transform.childCount; i++)
            {
                var childTransform = transform.GetChild(i);
                childTransform.gameObject.SetActive(true);
            }
        }
    }

    void OnMouseDown()
    {
        isClicked = true;
        Debug.Log("Mochie Nom Nom");
    }

}
