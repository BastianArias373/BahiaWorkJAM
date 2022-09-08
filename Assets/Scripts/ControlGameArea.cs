using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlGameArea : MonoBehaviour
{
    public GameObject areaDeJuego;
    public GameObject obstaculo; 
    [SerializeField] private Collider boxAreaDeJuego;
    [SerializeField] private Collider boxObstaculo;
    public void Awake()
    {
        boxAreaDeJuego = areaDeJuego.GetComponent<BoxCollider>();
        boxObstaculo = obstaculo.GetComponent<BoxCollider>();
    }
    void Update()
    {
        Debug.Log("BOX jugable: " + boxAreaDeJuego.bounds.size);
        Debug.Log("CAPSULE del obstaculo: " + boxObstaculo.bounds.size);
    }
}
