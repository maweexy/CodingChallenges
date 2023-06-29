using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    public List<CollectionItem> collectionItems;
    public Transform itemCollector;
    public Vector3 targetPos;
    private CollectionItem collectionItem;
    public float addWeight = 1;
    public Vector3 initialScale;

    // Start is called before the first frame update
    void Start()
    {
        collectionItem = new CollectionItem();
        Vector3 initialScale = itemCollector.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        int counterCollected = 0;
        foreach (CollectionItem item in collectionItems)
        {
            if (item.isCollected)
            {
                Debug.Log("isCollected");
                counterCollected ++;
                Debug.Log(counterCollected);
            }
        }
        itemCollector.localScale = new Vector3(addWeight + counterCollected, addWeight + counterCollected, addWeight + counterCollected);
        if (counterCollected == 8)
        {
            itemCollector.localScale = new Vector3(addWeight, addWeight, addWeight);
            Debug.Log("All " + counterCollected + " are collected!");
            foreach (CollectionItem item in collectionItems)
            {
                if (item.isClicked)
                {
                    item.isClicked = false;
                    item.isCollected = false;
                }
            }
        }    
    }
}
