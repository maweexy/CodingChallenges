using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShuffleObject : MonoBehaviour
{
    public Vector3 initialPos;
    private Transform objtoMove;
    private Vector3 targetPos;
    //public Vector3 controlPoint;
    public Vector3 newPosition;
    public float speed = 5f;
    public ShuffleController ShuffleController;
    public Renderer rend;
    //public float curveStrength = 0.25f;
    //public float curveOffset;
    void Start()
    {
        objtoMove = transform;
        initialPos = objtoMove.localPosition;
        rend = GetComponent<Renderer>();
        //curveOffset = Random.Range(0f, 2f * Mathf.PI);
    }
    void Update()
    {
        /*float t = Mathf.PingPong(Time.time * speed, 1f);
        float curveAmount = Mathf.Sin((t + curveOffset) * Mathf.PI) * curveStrength;
        Vector3 newPosition = initialPos + targetPos + Vector3.back * curveAmount;
        objtoMove.localPosition = Vector3.Lerp(objtoMove.localPosition, newPosition, speed * Time.deltaTime);*/
        float speedReset = 5f;
        newPosition = initialPos + targetPos;
        objtoMove.localPosition = Vector3.MoveTowards(objtoMove.localPosition, newPosition, speed*Time.deltaTime);
        //newPosition.z = Mathf.MoveTowards(newPosition.z, 0f, speed * Time.deltaTime);
        initialPos.z = Mathf.MoveTowards(initialPos.z, 0f, speedReset * Time.deltaTime);
        // for (float t =0; t <=1; t +=0.1f)
        // if (rend.enabled == true)
        // {
        //     if (transform.childCount > 0)
        //     {
        //         rend.enabled = false;
        //         ShuffleController.PlaceTheBall();
        //     }
        // }

        // {
        //     Vector3 point = CalculatePointOnCurve(t);
        // }
    }

    void OnMouseDown()
    {
        rend.enabled = false;
        ShuffleController.PlaceTheBall();
    }

    // private Vector3 CalculatePointOnCurve(float t)
    // {
    //     float u = 1 -t;
    //     float tt = t * t;
    //     float uu = u * u;

    //     Vector3 point = uu * initialPos + 2 * u * t * controlPoint + tt * newPosition;

    //     return point;
    // }
}
