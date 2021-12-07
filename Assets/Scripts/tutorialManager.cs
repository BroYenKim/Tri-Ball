using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorialManager : MonoBehaviour
{
    public GameObject playerBlue;
    public GameObject playerRed;
    public GameObject ball;

    public Text redBallText;
    public Text blueBallText;

    public Text instructions;

    public GameObject mainGameCanvas;
    public GameObject tutorialMessageBoard;
    public GameObject welcome;
    public GameObject gameFlow;
    public GameObject gameFlow2;
    public GameObject scoring;
    public GameObject dueling;
    public GameObject endMessage;
    GameObject[] tutorialArray;
    float tutorialTimer;
    float tutorialDelay;
    int indexOfTutorial;
    bool inMessageTutorial;
    public bool startOfGame = true;
    public bool shouldRestart = false;
    public bool gameOver = false;
    public static bool playerCanMove;
    public static bool gameStart;
    int testsPassed = 0;
    bool redPass = false;
    bool bluePass = false;

    float timer = 2f;

    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<audioManager>().Play("Theme");
        tutorialTimer = 1;
        tutorialDelay = 1;
        indexOfTutorial = 0;
        inMessageTutorial = true;
        tutorialArray =  new GameObject[] {welcome, gameFlow, gameFlow2, scoring, dueling};
        mainGameCanvas.SetActive(true);
        gameOver = false;
        playerCanMove = true;
        gameStart = true;
        instructions.text = "Welcome to Tri-Ball. Use the left joystick to move!";
    }

    // Update is called once per frame
    void Update()
    {
        if (inMessageTutorial) {
            gameManager.playerCanMove = false;
            playerBlue.GetComponent<playerMovement>().isInTutorial = false;
            playerRed.GetComponent<secondPlayerMovement>().isInTutorial = false;
            tutorialMessageBoard.SetActive(true);
            tutorialTimer -= Time.deltaTime;
            if(tutorialTimer <= 0) {
                tutorialDelay -= Time.deltaTime;
                if(indexOfTutorial < 7) {
                    tutorialArray[indexOfTutorial].SetActive(true);
                }
                if (tutorialDelay <= 0) {
                    if (indexOfTutorial < 5 && (playerBlue.GetComponent<playerMovement>().nextTutorial == true || playerRed.GetComponent<secondPlayerMovement>().nextTutorial == true)) {
                        indexOfTutorial+=1;
                        if (indexOfTutorial >= 5) {
                            tutorialMessageBoard.SetActive(false);
                            inMessageTutorial = false;
                            gameManager.playerCanMove = true;
                            playerBlue.GetComponent<playerMovement>().isInTutorial = true;
                            playerRed.GetComponent<secondPlayerMovement>().isInTutorial = true;
                            gameManager.playerCanMove = true;
                        }
                        else {
                            tutorialArray[indexOfTutorial-1].SetActive(false);
                            tutorialArray[indexOfTutorial].SetActive(true);
                            tutorialDelay = 1;
                        }
                    } 
                }
            }
        }
        else {
            if (testsPassed == 0)
            {
                walkTest();
            } else if (testsPassed == 1)
            {
                cameraTest();
            } else if (testsPassed == 2)
            {
                jumpTest();
            } else if (testsPassed == 3)
            {
                holdTest();
            } else if (testsPassed == 4)
            {
                dashTest();
            } else if (testsPassed == 5)
            {
                sideStepTest();
            } else if (testsPassed == 6)
            {
                ballTest();
            } else
            {
                FindObjectOfType<pauseMenu>().goToMenu();
            }

            if (!playerBlue.GetComponent<playerMovement>().canHold)
            {
                blueBallText.text = "Blue Ball";
            }
            else if (!playerRed.GetComponent<secondPlayerMovement>().canHold)
            {
                redBallText.text = "Red Ball";
            }
            else
            {
                blueBallText.text = "";
                redBallText.text = "";
            }
        }
    }

    void resetPosition()
    {
        playerRed.GetComponent<secondPlayerMovement>().resetPosition();
        playerBlue.GetComponent<playerMovement>().resetPosition();
        ball.GetComponent<ballBehavior>().resetState();
    }

    void walkTest()
    {
        if (playerRed.GetComponent<secondPlayerMovement>().moveInput != Vector2.zero)
        {
            redPass = true;
        }
        if (playerBlue.GetComponent<playerMovement>().moveInput != Vector2.zero)
        {
            bluePass = true;
        }

        if(redPass && bluePass)
        {
            timer -= Time.deltaTime;
            instructions.text = "Passed!";
            if (timer <= 0)
            {
                redPass = false;
                bluePass = false;
                resetPosition();
                timer = 2f;
                instructions.text = "Use the right joystick to look around!";
                testsPassed++;
            }
        }
    }

    void cameraTest()
    {
        if (playerRed.GetComponent<secondPlayerMovement>().cameraInput != Vector2.zero)
        {
            redPass = true;
        }
        if (playerBlue.GetComponent<playerMovement>().cameraInput != Vector2.zero)
        {
            bluePass = true;
        }

        if (redPass && bluePass)
        {
            timer -= Time.deltaTime;
            instructions.text = "Passed!";
            if (timer <= 0)
            {
                redPass = false;
                bluePass = false;
                resetPosition();
                timer = 2f;
                instructions.text = "Press the bottom face button to Jump! (Switch: B, Playstation: X, Xbox: A)";
                testsPassed++;
            }
        }
    }

    void jumpTest()
    {
        if (playerRed.GetComponent<secondPlayerMovement>().controls.Gameplay2.Jump.triggered == true)
        {
            redPass = true;
        }
        if (playerBlue.GetComponent<playerMovement>().controls.Gameplay.Jump.triggered == true)
        {
            bluePass = true;
        }

        if (redPass && bluePass)
        {
            timer -= Time.deltaTime;
            instructions.text = "Passed!";
            if (timer <= 0)
            {
                redPass = false;
                bluePass = false;
                resetPosition();
                timer = 2f;
                instructions.text = "Hold the top face button to Push-Back! (Switch: X, Playstation: Triangle, Xbox: Y)";
                testsPassed++;
            }
        }
    }

    void holdTest()
    {
        if (playerRed.GetComponent<secondPlayerMovement>().controls.Gameplay2.Hold.triggered == true)
        {
            redPass = true;
        }
        if (playerBlue.GetComponent<playerMovement>().controls.Gameplay.Hold.triggered == true)
        {
            bluePass = true;
        }

        if (redPass && bluePass)
        {
            timer -= Time.deltaTime;
            instructions.text = "Passed!";
            if (timer <= 0)
            {
                redPass = false;
                bluePass = false;
                resetPosition();
                timer = 2f;
                instructions.text = "Hold the left face button to Dash! (Switch: Y, Playstation: Square, Xbox: X)";
                testsPassed++;
            }
        }
    }

    void dashTest()
    {
        if (playerRed.GetComponent<secondPlayerMovement>().controls.Gameplay2.Dash.triggered == true)
        {
            redPass = true;
        }
        if (playerBlue.GetComponent<playerMovement>().controls.Gameplay.Dash.triggered == true)
        {
            bluePass = true;
        }

        if (redPass && bluePass)
        {
            timer -= Time.deltaTime;
            instructions.text = "Passed!";
            if (timer <= 0)
            {
                redPass = false;
                bluePass = false;
                resetPosition();
                timer = 2f;
                instructions.text = "Hold the right face button to Sidestep! (Switch: A, Playstation: Circle, Xbox: B)";
                testsPassed++;
            }
        }
    }
    void sideStepTest()
    {
        if (playerRed.GetComponent<secondPlayerMovement>().controls.Gameplay2.sideStep.triggered == true)
        {
            redPass = true;
        }
        if (playerBlue.GetComponent<playerMovement>().controls.Gameplay.sideStep.triggered == true)
        {
            bluePass = true;
        }

        if (redPass && bluePass)
        {
            timer -= Time.deltaTime;
            instructions.text = "Passed!";
            if (timer <= 0)
            {
                redPass = false;
                bluePass = false;
                resetPosition();
                timer = 2f;
                instructions.text = "press the right shoulder button to pick up the ball!";
                testsPassed++;
            }
        }
    }

    void ballTest()
    {
        if (playerRed.GetComponent<secondPlayerMovement>().canHold == false 
            || playerBlue.GetComponent<playerMovement>().canHold == false)
        {
            redPass = true;
        }
        if (redPass)
        {
            instructions.text = "Throw it by pressing the right shoulder button!";
            if (playerRed.GetComponent<secondPlayerMovement>().canHold == true
            && playerBlue.GetComponent<playerMovement>().canHold == true)
            {
                bluePass = true;
            }
            if (bluePass == true)
            {
                timer -= Time.deltaTime;
                instructions.text = "Passed! Have fun :)";
                if (timer <= 0)
                {
                    testsPassed++;
                }
            }
        }
    }
}
