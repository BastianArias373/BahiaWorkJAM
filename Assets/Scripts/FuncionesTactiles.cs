using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionesTactiles : MonoBehaviour
{
    [SerializeField] private Camera cam;
    Vector3 posicion;

    private void Awake()
    {
        cam = Camera.main;
    }

    void Update()
    {
        foreach (Touch miToque in Input.touches)
        {
            Debug.Log("ID: " + miToque.fingerId);
        }

        if (Input.touchCount > 0)
        {
            Touch miToque = Input.GetTouch(0);
            posicion = cam.ScreenToViewportPoint(miToque.position);
            Debug.Log("X: " + posicion.x + "  " + "Y: " + posicion.y);
        }
    }
}
