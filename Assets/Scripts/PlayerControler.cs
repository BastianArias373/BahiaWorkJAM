using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    float horizontalMove;
    float verticalMove;
    public float runHorizontalMove = 3;
    public float runVerticalMove = 3;
    public float runSpeed = 2;
    [SerializeField] private Joystick stick;

    public Vector2 gravity;
    public Vector2 jumpSpeed;
    private Rigidbody rb;
    private bool enElAire;


    [SerializeField] private Camera cam;

    private void Awake()
    {
        //Physics2D.gravity = gravity;
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
        Physics.gravity = gravity;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += new Vector3(
            Move().x,
            Move().y,
            0) 
            * Time.deltaTime * runSpeed;
        Salto();
    }

    public Vector2 Move()
    {
        horizontalMove = stick.Horizontal * runHorizontalMove;
        verticalMove = stick.Vertical * runVerticalMove;
        return new Vector2(horizontalMove,verticalMove);
    }

   

    public void Salto()
    {
        foreach (Touch toque in Input.touches)
        {
            if(Input.touchCount >= 0 
                && toque.phase == TouchPhase.Began 
                && cam.ScreenToViewportPoint(toque.position).x > 0.5 
                && !enElAire)
            {
                rb.velocity = jumpSpeed;
                enElAire = true;
            }
        }

    }

    


    private void OnCollisionEnter(Collision collision)
    {
        enElAire = false;
    }
}
