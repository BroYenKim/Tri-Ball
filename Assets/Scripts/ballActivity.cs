using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ballActivity : MonoBehaviour
{
    ControllerInput controls;
    public float speed = 10;
    public bool canHold = true;
    public bool isClose = false;
    public float maxDistance = 5;
    public GameObject ball;
    public GameObject gameCamera;
    public Transform guide;

    // Update is called once per frame
    void Update()
    {

        if (!canHold && ball)
        {
            ball.transform.position = guide.position;
        }
    }

    void Awake()
    {
        controls = new ControllerInput();
        controls.Gameplay.Ball.performed += ctx => callInput();
    }

    void callInput()
    {
        if(isClose == true)
        {
            if (!canHold) throwBall();
            else pickUp();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(Vector3.Distance(other.transform.position, guide.position) < maxDistance) {
                isClose = true;
         }
        else
        {
            isClose = false;
        }
    }

    void pickUp()
    {
        if (ball != null)
        {
            ball.transform.SetParent(guide);
            ball.GetComponent<Rigidbody>().useGravity = false;
            ball.transform.localRotation = transform.rotation;
            ball.transform.position = guide.position;
            ball.GetComponent<Rigidbody>().freezeRotation = true;
            canHold = false;
        }
    }

    void throwBall()
    {
        if (ball != null)
        {
            ball.GetComponent<Rigidbody>().useGravity = true;
            ball.GetComponent<Rigidbody>().freezeRotation = false;
            ball = null;
            guide.GetChild(0).gameObject.GetComponent<Rigidbody>().velocity = gameCamera.transform.forward * speed;
            guide.GetChild(0).parent = null;
            canHold = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            if (!ball) ball = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            if (canHold)
            {
                ball = null;
            }
        }
    }
}
