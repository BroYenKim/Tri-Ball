using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class yardLineTrack : MonoBehaviour
{
    public GameObject playerOne;
    public GameObject playerTwo;
    public Text yardLineTimer;
    public Text yardLine;
    float time = 5f; 
    float turnoverTime = 1f;
    bool inDuel;
    string timeText;
    float targetPosPlayerOne = -21.5f;
    float targetPosPlayerTwo = 21.5f;
    float currentPosPlayerOne; 
    float currentPosPlayerTwo;
    bool didTurnover; 

    // Update is called once per frame
    void Update()
    {
        inDuel = (playerOne.GetComponent<playerMovement>().inDuel && playerTwo.GetComponent<secondPlayerMovement>().inDuel);
        if(!inDuel) {
            if(!playerOne.GetComponent<playerMovement>().canHold) {
                if (time > 0) {
                    time -= Time.deltaTime;
                    currentPosPlayerOne = playerOne.transform.position.x;
                    if (currentPosPlayerOne >= targetPosPlayerOne) {
                        time = 5f;
                        targetPosPlayerOne += 21.5f;
                    }
                }
                int seconds = (int)(time%60);
                timeText = seconds.ToString();
                yardLineTimer.text = timeText;
                yardLine.text = "SHOT CLOCK:";
                if (time <= 0) {
                    if (turnoverTime > 0) {
                        turnoverTime -= Time.deltaTime;
                        yardLine.text = "TURNOVER!";
                        yardLineTimer.text = "";
                    }
                    else if (turnoverTime <= 0) {
                        playerOne.GetComponent<playerMovement>().didTurnover = true;
                        targetPosPlayerOne = -21.5f;
                        time = 5f;
                        turnoverTime = 1f;
                        yardLineTimer.text = "";
                        yardLine.text = "";
                    }
                }
            }
            else if(!playerTwo.GetComponent<secondPlayerMovement>().canHold) {
                if (time > 0) {
                    time -= Time.deltaTime;
                    currentPosPlayerTwo = playerTwo.transform.position.x;
                    if (currentPosPlayerTwo <= targetPosPlayerTwo) {
                        time = 5f;
                        targetPosPlayerTwo -= 21.5f;
                    }
                }
                int seconds = (int)(time%60);
                timeText = seconds.ToString();
                yardLineTimer.text = timeText;
                yardLine.text = "SHOT CLOCK:";
                if (time <= 0) {
                    if (turnoverTime > 0) {
                        turnoverTime -= Time.deltaTime;
                        yardLine.text = "TURNOVER!";
                        yardLineTimer.text = "";
                    }
                    else if (turnoverTime <= 0) {
                        playerTwo.GetComponent<secondPlayerMovement>().didTurnover = true;
                        targetPosPlayerTwo = 21.5f;
                        time = 5f;
                        turnoverTime = 1f;
                        yardLineTimer.text = "";
                        yardLine.text = "";
                    }
                }
            }
            else {
                targetPosPlayerOne = -21.5f;
                targetPosPlayerTwo = 21.5f;
                time = 5f;
                turnoverTime = 1f;
                yardLineTimer.text = "";
                yardLine.text = "";
            }
        }
        
    }
}
