using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovements : MonoBehaviour
{
    //float m_fieldOfView;
    float maxZoom;
    float minZoom;
    [SerializeField]
    float zoomSpeed;
    [SerializeField]
    float panningSpeed;
    string horizontalAxis = "Horizontal";
    string verticalAxis = "Vertical";
    void Start()
    {
        maxZoom = 60.0f;
        minZoom = 30.0f;
        //zoomSpeed = 10f;   
    }
    void Update()
    {
        //Zooming IN/OUt
        float zoomInput = Input.GetAxis("Mouse ScrollWheel");
        float newZoom = Camera.main.fieldOfView - zoomInput * zoomSpeed;
        newZoom = Mathf.Clamp(newZoom, minZoom, maxZoom);
        Camera.main.fieldOfView = newZoom;

        //Panning H/V
        float horizontalInput = Input.GetAxis(horizontalAxis);
        float verticalInput = Input.GetAxis(verticalAxis);

        Vector3 panning = new Vector3(horizontalInput, 0f, verticalInput);
        panning.Normalize();

        transform.Translate(panning * panningSpeed *Time.deltaTime);
    }
}
