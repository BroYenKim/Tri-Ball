using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;
using UnityEngine.UI;

public class secondPlayerMovement : MonoBehaviour
{
    Animator animator;
    public CharacterController controller;

    public GameObject opposingPlayer;
    public gameManager manager;
    public GameObject metrics;

    public float speed = 10f;
    public float gravity = -25f;
    public float jumpHeight = 2f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    public ControllerInput controls;

    public Vector2 moveInput;
    public Vector2 cameraInput;

    public float mouseSensitivity = 300f;

    float xRotation = 0f;

    public float ballSpeed = 30;
    public bool canHold = true;
    public bool isClose = false;
    public float maxDistance = 3;
    public GameObject face;
    public GameObject ball;
    public GameObject gameCamera;
    public Transform guide;

    public bool usingMove = false;

    bool usingDash = false;
    public float dashCoolDown = 0f;
    public float dashSpeedUp = 0.2f;
    public float dashAccel = 1f;

    public bool usingHold = false;
    public float holdCoolDown = 0f;
    public float holdSpeedUp = 0.075f;

    bool usingSideStep = false;
    public float sideStepCoolDown = 2f;
    public float sideStepSpeedUp = 0.3f;
    public float sideStepSpeedUpTwo = 0.15f;

    float walkCoolDown = 0f;
    //Duel
    public bool inDuel = false;
    public bool didTurnover = false;
    public bool scored = false; 

    public bool moveOn = false;
    public bool nextTutorial = false;
    public bool quit = false;

    // Update is called once per frame

    Vector3 startPosition = new Vector3(8, 104, 0);
    Vector3 startRotation = new Vector3(0, -90, 0);
    Vector3 dPosition = new Vector3(-37, 104, -11);
    Vector3 oPosition = new Vector3 (48, 104, 11);

    bool walking = false;
    bool jumping = false;
    bool backwards = false;
    bool throwing = false;
    float throwingTimer = -1;

    public bool quit2 = false;
    bool quit3 = true;

    public bool isInTutorial;

    public Text dashCD;
    public Text pushBackCD;
    public Text sideStepCD;

    void callThrowInput()
    {
        if (!inDuel && throwingTimer < 0 && opposingPlayer.GetComponent<playerMovement>().canHold)
        {
            if (isClose == true)
            {
                if (!canHold)
                {
                    throwing = true;
                    throwingTimer = 0.25f;
                }
                else pickUp();
            }
        }
    }

    void Awake()
    {
        var gamepad2 = Gamepad.all[1];
        var playerTwo = InputUser.PerformPairingWithDevice(gamepad2);
        controls = new ControllerInput();
        controls.Gameplay2.Movement.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        controls.Gameplay2.Movement.canceled += ctx => moveInput = Vector2.zero;
        controls.Gameplay2.Jump.performed += ctx => Jump();

        controls.Gameplay2.Dash.performed += ctx => setDash();
        controls.Gameplay2.Dash.canceled += ctx => usingDash = false;

        controls.Gameplay2.sideStep.performed += ctx => setSideStep();
        controls.Gameplay2.sideStep.canceled += ctx => usingSideStep = false;

        controls.Gameplay2.Hold.performed += ctx => setHold();
        controls.Gameplay2.Hold.canceled += ctx => usingHold = false;

        controls.Gameplay2.Camera.performed += ctx => cameraInput = ctx.ReadValue<Vector2>();
        controls.Gameplay2.Camera.canceled += ctx => cameraInput = Vector2.zero;

        controls.Gameplay2.Ball.performed += ctx => callThrowInput();

        controls.Gameplay2.continueTutorial.performed += ctx => nextTutorial = true;
        controls.Gameplay2.continueTutorial.canceled += ctx => nextTutorial = false;

        controls.Gameplay2.pause.performed += ctx => pause();

        controls.Gameplay2.mainMenu.performed += ctx => quit = true;
        controls.Gameplay2.mainMenu.canceled += ctx => quit = false;

        controls.Gameplay2.quit2.performed += ctx => quit2 = true;
        controls.Gameplay2.quit2.canceled += ctx => quit2 = false;

        controls.Gameplay2.quit3.performed += ctx => quit3 = true;
        controls.Gameplay2.quit3.canceled += ctx => quit3 = false;

        playerTwo.AssociateActionsWithUser(controls);
    }

    private void pause()
    {
        if (gameManager.gameStart == true || isInTutorial)
        {
            Debug.Log("paused");
            FindObjectOfType<pauseMenu>().pressedPause();
        }
    }

    void setDash()
    {
        usingDash = true;
        if (dashCoolDown <= 0 && !inDuel && (gameManager.playerCanMove || isInTutorial))
        {
            FindObjectOfType<audioManager>().Play("Dash02");
        }
    }

    void setSideStep()
    {
        usingSideStep = true;
        if (sideStepCoolDown <= 0 && !inDuel && (gameManager.playerCanMove || isInTutorial))
        {
            FindObjectOfType<audioManager>().Play("SideStep02");
        }
    }

    void setHold()
    {
        usingHold = true;
        if (holdCoolDown <= 0 && !inDuel && (gameManager.playerCanMove || isInTutorial))
        {
            FindObjectOfType<audioManager>().Play("Hold02");
        }
    }

    void Jump()
    {
        if (isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            metrics.GetComponent<metrics>().AddToJumps(1);
        }
    }


    void Dash()
    {
        if (dashCoolDown <= 0)
        {
            if (usingDash)
            {
                if (dashSpeedUp >= 0f)
                {
                    dashSpeedUp -= Time.deltaTime;
                    Vector3 dashing = transform.forward * dashAccel;
                    controller.Move(dashing * Time.deltaTime);
                    dashAccel += Time.deltaTime * 400;
                }
                else
                {
                    metrics.GetComponent<metrics>().AddToDashes(1);
                    dashAccel = 1;
                    dashSpeedUp = 0.2f;
                    dashCoolDown = 2f;
                    usingDash = false;
                }
            }
        }
        else
        {
            usingDash = false;
        }
    }

    void Hold()
    {
        if (holdCoolDown <= 0)
        {
            if (usingHold)
            {
                if (holdSpeedUp >= 0f)
                {
                    holdSpeedUp -= Time.deltaTime;
                    Vector3 holding = transform.forward * 60f;
                    controller.Move(holding * Time.deltaTime);
                }
                else
                {
                    metrics.GetComponent<metrics>().AddToPushBacks(1);
                    holdSpeedUp = 0.075f;
                    holdCoolDown = 1f;
                    usingHold = false;
                }
            }
        }
        else
        {
            usingHold = false;
        }
    }
    void sideStep()
    {
        if (sideStepCoolDown <= 0)
        {
            if (usingSideStep)
            {
                if (sideStepSpeedUp >= 0f)
                {
                    sideStepSpeedUp -= Time.deltaTime;
                    Vector3 dashing = transform.right * moveInput.x + transform.forward * moveInput.y;
                    controller.Move(dashing * 3f * Time.deltaTime);
                }
                else if (sideStepSpeedUpTwo >= 0)
                {
                    sideStepSpeedUpTwo -= Time.deltaTime;
                    Vector3 dashing = transform.right * moveInput.x + transform.forward * moveInput.y;
                    controller.Move(dashing * 45f * Time.deltaTime);
                }
                else
                {
                    metrics.GetComponent<metrics>().AddToSideSteps(1);
                    sideStepSpeedUp = 0.3f;
                    sideStepSpeedUpTwo = 0.15f;
                    sideStepCoolDown = 2f;
                    usingSideStep = false;
                }
            }
        }
        else
        {
            usingSideStep = false;
        }
    }
    void checkMove()
    {
        if (usingDash) Dash();
        else if (usingHold) Hold();
        else if (usingSideStep) sideStep();
    }

    // Update is called once per frame
    void Update()
    {
        if ((gameManager.playerCanMove || isInTutorial)) {
            if (isGrounded)
            {
                jumping = false;
            }
            else
            {
                jumping = true;
            }
            if (walkCoolDown > 0)
            {
                walkCoolDown -= Time.deltaTime;
            }
            if (throwingTimer > 0)
            {
                throwingTimer -= Time.deltaTime;
                if (throwingTimer <= 0)
                {
                    throwBall();
                }
            }
            if (throwingTimer <= 0)
            {
                throwing = false;
            }
            else if (throwingTimer <= 0) throwing = false;
            usingMove = (usingDash || usingHold || usingSideStep);
            if (dashCoolDown > 0) dashCoolDown -= Time.deltaTime;
            if (holdCoolDown > 0) holdCoolDown -= Time.deltaTime;
            if (sideStepCoolDown > 0) sideStepCoolDown -= Time.deltaTime;
            if (!inDuel && !didTurnover && !scored)
            {
                if (!canHold && ball)
                {
                    ball.transform.position = guide.position;
                }

                isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

                if (isGrounded && velocity.y < 0)
                {
                    velocity.y = -2f;
                }

                if (!usingMove)
                {
                    float x = moveInput.x;
                    float z = moveInput.y;

                    if (x != 0 && z != 0)
                    {
                        if (z > Mathf.Abs(x))
                        {
                            walking = true;
                            backwards = false;

                        }
                        else
                        {
                            backwards = true;
                            walking = false;
                        }
                        if (isGrounded)
                        {
                            jumping = false;
                            Walk();
                        }
                        else
                        {
                            jumping = true;
                        }
                    }
                    else
                    {
                        walking = false;
                        backwards = false;
                    }
                    Vector3 move = transform.right * x + transform.forward * z;
                    controller.Move(move * speed * Time.deltaTime);
                }

                float mouseX = cameraInput.x * mouseSensitivity * Time.deltaTime;
                float mouseY = cameraInput.y * mouseSensitivity * Time.deltaTime;
                xRotation -= mouseY;
                xRotation = Mathf.Clamp(xRotation, -90f, 45f);

                face.transform.localRotation = Quaternion.Euler(0f, 0f, xRotation);
                gameCamera.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
                gameCamera.transform.position = face.transform.position;
                transform.Rotate(Vector3.up * mouseX);

                if (usingMove)
                {
                    checkMove();
                }

                velocity.y += gravity * Time.deltaTime;

                controller.Move(velocity * Time.deltaTime);
            }
            if (didTurnover || scored)
            {
                if (didTurnover)
                {
                    letGoOfBall();
                }
                defensePosition();
                opposingPlayer.GetComponent<playerMovement>().offensePosition();
                didTurnover = false;
                scored = false;
            }
            if (transform.position.x < -43)
            {
                controller.enabled = false;
                transform.position = new Vector3(-43, transform.position.y, transform.position.z);
                controller.enabled = true;
            }

            animator.SetBool("isWalking", walking);
            animator.SetBool("isJumping", jumping);
            animator.SetBool("isHolding", usingHold);
            animator.SetBool("isSideStepping", usingSideStep);
            animator.SetBool("isDashing", usingDash);
            animator.SetBool("isBackward", backwards);
            animator.SetBool("isThrowing", throwing);
        }
        else if (gameManager.gameStart == true)
        {
            if (quit2 && quit3)
            {
                pause();
                FindObjectOfType<pauseMenu>().goToMenu();
            }
        }
        if (!isInTutorial) handleSkillUI();
        if (!gameManager.playerCanMove)
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isJumping", false);
            animator.SetBool("isHolding", false);
            animator.SetBool("isSideStepping", false);
            animator.SetBool("isDashing", false);
            animator.SetBool("isBackward", false);
            animator.SetBool("isThrowing", false);
        }
    }

    void handleSkillUI()
    {
        if (dashCoolDown > 0)
        {
            dashCD.text = string.Format("{0:0.0}", dashCoolDown);
        }
        else
        {
            dashCD.text = "";
        }
        if (sideStepCoolDown > 0)
        {
            sideStepCD.text = string.Format("{0:0.0}", sideStepCoolDown);
        }
        else
        {
            sideStepCD.text = "";
        }
        if (holdCoolDown > 0)
        {
            pushBackCD.text = string.Format("{0:0.0}", holdCoolDown);
        }
        else
        {
            pushBackCD.text = "";
        }
    }

    void letGoOfBall()
    {
        ball.GetComponent<Rigidbody>().useGravity = true;
        ball.GetComponent<Rigidbody>().freezeRotation = false;
        ball = null;
        guide.GetChild(0).parent = null;
        canHold = true;
    }

    void OnEnable()
    {
        controls.Gameplay2.Enable();
    }

    private void OnDisable()
    {
        if (controls != null)
        {
            controls.Gameplay2.Disable();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (Vector3.Distance(other.transform.position, guide.position) < maxDistance)
        {
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
            throwing = false;
            throwingTimer = -1;
            ball.GetComponent<Rigidbody>().useGravity = true;
            ball.GetComponent<Rigidbody>().freezeRotation = false;
            ball = null;
            guide.GetChild(0).gameObject.GetComponent<Rigidbody>().velocity = gameCamera.transform.forward * ballSpeed;
            guide.GetChild(0).parent = null;
            canHold = true;
            if ((gameManager.playerCanMove || isInTutorial))
            {
                FindObjectOfType<audioManager>().Play("ThrowBall01");
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            if (!ball) ball = other.gameObject;
        }
        if ((usingMove || opposingPlayer.GetComponent<playerMovement>().usingMove) && (other.gameObject.tag == "player" && (!canHold 
            || opposingPlayer.GetComponent<playerMovement>().canHold == false)))
        {
            inDuel = true;
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

    private void Walk()
    {
        if (walkCoolDown <= 0)
        {
            FindObjectOfType<audioManager>().Play("Walk02");
            walkCoolDown = 0.25f;
        }
    }

    public void resetPosition()
    {
        if (ball != null)
        {
            letGoOfBall();
        }
        controller.enabled = false;
        gameObject.transform.position = startPosition;
        transform.rotation = Quaternion.Euler(startRotation);
        controller.enabled = true;
    }
    public void defensePosition() {
        controller.enabled = false;
        transform.position = dPosition;
        transform.rotation = Quaternion.Euler(startRotation);
        controller.enabled = true;
    }

    public void offensePosition() {
        controller.enabled = false;
        transform.position = oPosition;
        transform.rotation = Quaternion.Euler(startRotation);
        controller.enabled = true;
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
}
