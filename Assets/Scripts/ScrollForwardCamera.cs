using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollForwardCamera : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] float velGame = 2;

    private void Awake()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        transform.position += new Vector3(velGame, transform.position.y, 0) * Time.deltaTime;
    }
}
