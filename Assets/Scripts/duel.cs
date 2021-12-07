using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class duel : MonoBehaviour
{
    public GameObject playerOne;
    public GameObject playerTwo;
    public GameObject metrics;
    public GameObject duelImage;
    GameObject winner;
    GameObject loser;
    CharacterController winnerController;
    CharacterController loserController;

    bool canHold;

    //Duel variables
    public float gameStartCountdown = 0f;
    public float gameCountdown = 0f;
    public int blueButtonMashCounter = 0;
    public int  redButtonMashCounter = 0;
    public bool inDuel = false;
    public Text gameDisplay;
    public Text countdownDisplay;
    public Slider blueButtonDisplay;
    public Slider redButtonDisplay;
    
    bool isPushBack = false;
    float dashSpeedUp = 0.2f;
    bool isInRealDuel = false;


    // Start is called before the first frame update
    void Start()
    {
        blueButtonDisplay.value = 0;
        redButtonDisplay.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        inDuel = (playerOne.GetComponent<playerMovement>().inDuel && playerTwo.GetComponent<secondPlayerMovement>().inDuel);
        if (inDuel)
        {
            if (playerOne.GetComponent<playerMovement>().usingHold && !playerTwo.GetComponent<secondPlayerMovement>().usingMove && !isPushBack && gameCountdown == 0)
            {
                blueButtonMashCounter = 100;
                redButtonMashCounter = 0;
                loser = playerTwo;
                loserController = loser.GetComponent<secondPlayerMovement>().controller;
                isPushBack = true;
            }
            else if (!playerOne.GetComponent<playerMovement>().usingMove && playerTwo.GetComponent<secondPlayerMovement>().usingHold && !isPushBack && gameCountdown == 0)
            {
                blueButtonMashCounter = 0;
                redButtonMashCounter = 100;
                loser = playerOne;
                loserController = loser.GetComponent<playerMovement>().controller;
                isPushBack = true;
            }
            else if (!isPushBack && !isInRealDuel)
            {
                gameCountdown = 3f;
                isInRealDuel = true;
                metrics.GetComponent<metrics>().AddToDuels(1);
                duelImage.SetActive(true);
            }
            
            if (gameCountdown > 0.1)
            {
                countdownDisplay.text = gameCountdown.ToString();
                gameCountdown -= Time.deltaTime;
                if (playerOne.GetComponent<playerMovement>().usingMove)
                {
                    blueButtonMashCounter += (int)(500 * Time.deltaTime);
                    blueButtonDisplay.value += (float)(0.5*Time.deltaTime);
                }
                if (playerTwo.GetComponent<secondPlayerMovement>().usingMove)
                {
                    redButtonMashCounter += (int)(500 * Time.deltaTime);
                    redButtonDisplay.value += (float)(0.5*Time.deltaTime);
                }
            }
            else
            {
                if (isPushBack)
                {
                    canHold = true;
                }
                else
                {
                    if (blueButtonMashCounter > redButtonMashCounter)
                    {
                        winner = playerOne;
                        loser = playerTwo;
                        canHold = winner.GetComponent<playerMovement>().canHold;
                        winnerController = winner.GetComponent<playerMovement>().controller;
                        loserController = loser.GetComponent<secondPlayerMovement>().controller;
                        countdownDisplay.text = "";
                    }
                    else
                    {
                        loser = playerOne;
                        winner = playerTwo;
                        canHold = winner.GetComponent<secondPlayerMovement>().canHold;
                        winnerController = winner.GetComponent<secondPlayerMovement>().controller;
                        loserController = loser.GetComponent<playerMovement>().controller;
                        countdownDisplay.text = "";
                    }
                }
                if (canHold)
                {
                    if (dashSpeedUp >= 0f)
                    {
                        dashSpeedUp -= Time.deltaTime;
                        Vector3 dashing = loser.transform.forward * 70f * -1;
                        loserController.Move(dashing * Time.deltaTime);
                    }

                }
                else
                {
                    if (dashSpeedUp >= 0f)
                    {
                        dashSpeedUp -= Time.deltaTime;
                        Vector3 dashing = winner.transform.forward * 70f;
                        winnerController.Move(dashing * Time.deltaTime);
                    }
                }
                if (dashSpeedUp < 0)
                {
                    duelImage.SetActive(false);
                    playerOne.GetComponent<playerMovement>().inDuel = false;
                    dashSpeedUp = 0.2f;
                    gameStartCountdown = 3f;
                    gameCountdown = 0f;
                    blueButtonDisplay.value = 0;
                    blueButtonMashCounter = 0;
                    playerTwo.GetComponent<secondPlayerMovement>().inDuel = false;
                    redButtonDisplay.value = 0;
                    redButtonMashCounter = 0;
                    isPushBack = false;
                    isInRealDuel = false;
                }
            }
        }
    }
}
