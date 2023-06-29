using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuffleController : MonoBehaviour
{
    public GameObject ballThing;
    public List<ShuffleObject> ShuffleObjects = new();
    public List<Vector3> targetPositions = new();
    public List<Vector3> newLoc = new();
    int randomIndex = 0;

    void Start()
    {
        PlaceTheBall();
    }


    void Update()
    {
        // Vector3 initPos = ShuffleObjects[0].initialPos;
        // Debug.Log(initPos.x + " "+initPos.y + " "+ initPos.z);
        if (Input.GetKeyDown("space"))
        {
            //PlaceTheBall();
            foreach (ShuffleObject obj in ShuffleObjects)
            {
                Renderer renderer = obj.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.enabled = true;
                }
            }
            Shuffle();
        }    
    }
     
    void Randomizer()
    {
        bool first = false;
        bool second = false;
        bool third = false;
        int i = 0;

        while (i < ShuffleObjects.Count)
        {
            randomIndex = Random.Range(0, 3);
            switch (randomIndex)
            {
                case 0:
                    if (first != true) {first = true; newLoc.Add(new  Vector3(targetPositions[0].x, targetPositions[0].y, targetPositions[0].z)); i++;}
                    break;
                case 1:
                    if (second != true) {second = true; newLoc.Add(new  Vector3(targetPositions[1].x, targetPositions[1].y, targetPositions[1].z)); i++;}
                    break;
                case 2:
                    if (third != true) {third = true; newLoc.Add(new  Vector3(targetPositions[2].x, targetPositions[2].y, targetPositions[2].z)); i++;}
                    break;
            }
        Debug.Log(" " + targetPositions[randomIndex].x + " " + targetPositions[randomIndex].y + " " + targetPositions[randomIndex].z);
        }
    }
    void Shuffle()
    {
        //float speed = 5f;
        newLoc.Clear();
        Randomizer();

        for (int i = 0; i < ShuffleObjects.Count; i ++)
        {
            var startZ = newLoc[i].z;
            if (newLoc[i].x == 2.5f)
            {
                startZ = -2.5f;
            }
            else if (newLoc[i].x == -2.5f)
            {
                startZ = 2.5f;
            }
            ShuffleObjects[i].initialPos = new Vector3 (newLoc[i].x,newLoc[i].y,startZ);
            //startZ = Mathf.MoveTowards(startZ, 0f, speed * Time.deltaTime);
        }
    }
    public void PlaceTheBall()
    {
        foreach (ShuffleObject obj in ShuffleObjects)
        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if (obj.transform.childCount > 0)
            {
                renderer.enabled = false;
            }
        }    
        int randBall = Random.Range(0, 3);
        var shuffleObjtransform = ShuffleObjects[randBall].transform;
        ballThing.transform.SetParent(shuffleObjtransform, false);
        Debug.Log(randBall);
    }
}    
