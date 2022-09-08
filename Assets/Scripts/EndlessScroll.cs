using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndlessScroll : MonoBehaviour
{
    public float scrollFactor = -1;
    Rigidbody2D rbObs;
    Collider capsuleObstaculo;
    private void Awake()
    {
        rbObs = GetComponent<Rigidbody2D>();
        capsuleObstaculo = GetComponent<BoxCollider>();

    }
    private void OnTriggerExit(Collider col)
    {
        if (col.tag == "gameArea")
        {
            transform.position += Vector3.right * (col.bounds.size.x + capsuleObstaculo.bounds.size.x);
        }
    }

    private void Update()
    {
        transform.position += Vector3.right * scrollFactor * Time.deltaTime;
    }
}
