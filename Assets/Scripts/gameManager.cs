using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject playerBlue;
    public GameObject playerRed;
    public GameObject ball;

    //UI related gameobjects
    public GameObject startScreen;

    //tutorial related gameobjects
    public GameObject messageBoard;
    public GameObject welcome;
    public GameObject abilities;
    public GameObject gameFlow;
    public GameObject gameFlow2;
    public GameObject scoring;
    public GameObject dueling;
    public GameObject endMessage;
    public GameObject controllerLayout;

    public Text redBallText;
    public Text blueBallText;

    public GameObject mainGameCanvas;
    public Text countdown;
    public Text gameTimer;
    public Text half;
    public Text redScore;
    public Text blueScore;
    public GameObject endGameScene;
    public GameObject redWin;
    public GameObject blueWin;
    float minutes;
    float seconds;
    float timeRemaining;
    float pauseTimer;
    int numHalfs = 1;
    public bool startOfGame = true;
    public bool shouldRestart = false;
    public bool gameOver = false;
    int redScoreInt;
    int blueScoreInt;
    bool playingTheme = false;
    bool playedCountdown = false;
    float startGameTimer;
    public static bool playerCanMove;
    public static bool gameStart;
    public float TIME_REMAINING = 120f;
    bool endGame;

    //public GameObject bluePoints;


    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<audioManager>().Stop("Theme");
        mainGameCanvas.SetActive(true);
        redScore.text = "0";
        blueScore.text = "0";
        playingTheme = false;
        timeRemaining = TIME_REMAINING;
        pauseTimer = 0f;
        startOfGame = true;
        gameOver = false;
        shouldRestart = false;
        endGameScene.SetActive(false);
        blueWin.SetActive(false);
        redWin.SetActive(false);
        startGameTimer = 3.5f;
        playerCanMove = false;
        gameStart = false;
        endGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (numHalfs >= 3 && redScore.text != blueScore.text)
        {
            if (playerBlue.GetComponent<playerMovement>().quit == true || playerRed.GetComponent<secondPlayerMovement>().quit == true)
            {
                Debug.Log("backtomenu");
                //FindObjectOfType<pauseMenu>().pressedPause();
                SceneManager.LoadScene("Menu");
            }
        }
        FindObjectOfType<audioManager>().Stop("Start");
        startScreen.SetActive(false);
        if(!playedCountdown) {
            if (numHalfs > 1) {
                half.text = "Next Round";
            }
            else {
                half.text = "Starting";
            }
            FindObjectOfType<audioManager>().Play("countdown");
            playedCountdown = true;
        }
        if (startGameTimer > 0) {
            seconds = Mathf.FloorToInt(startGameTimer%60);
            startGameTimer -= Time.deltaTime;
            string countdownText = startGameTimer.ToString("0");
            countdown.text = countdownText;
        }
        if (startGameTimer <= 0 && gameStart == false)
        {
            gameStart = true;
            playerCanMove = true;
            if (numHalfs > 1) {
                FindObjectOfType<audioManager>().Play("Theme2");
            }
        }
        else if (gameStart) {
            countdown.text = "";
            if(!playingTheme && numHalfs == 1) {
                FindObjectOfType<audioManager>().Play("Theme");
                playingTheme = true;
            }
            if (pauseTimer > 0)
            {
                pauseTimer -= Time.deltaTime;
                if (pauseTimer <= 0)
                {
                    numHalfs++;
                    FindObjectOfType<audioManager>().Stop("Theme");
                    FindObjectOfType<audioManager>().Stop("Theme2");
                    FindObjectOfType<audioManager>().Play("halftime");
                    playedCountdown = false;
                    gameStart = false;
                    startGameTimer = 3.5f;
                    playingTheme = false;
                    if (numHalfs == 2)
                    {
                        secondHalf();
                    } else if (numHalfs >= 3 && redScore.text != blueScore.text)
                    {
                        endGame = true;
                        endGameScene.SetActive(true);
                        int.TryParse(redScore.text, out redScoreInt);
                        int.TryParse(blueScore.text, out blueScoreInt);
                        if (redScoreInt > blueScoreInt) {
                            redWin.SetActive(true);
                        }
                        else {
                            blueWin.SetActive(true);
                        }
                        if(playerBlue.GetComponent<playerMovement>().quit == true || playerRed.GetComponent<secondPlayerMovement>().quit == true) {
                            FindObjectOfType<pauseMenu>().pressedPause();
                            SceneManager.LoadScene("Menu");
                        }
                    } 
                    else if(redScore.text == blueScore.text) {
                        timeRemaining = 30;
                        resetPosition();
                    }
                }
            }
            else
            {
                if (timeRemaining > 0)
                {
                    minutes = Mathf.FloorToInt(timeRemaining / 60);
                    seconds = Mathf.FloorToInt(timeRemaining % 60);
                    timeRemaining -= Time.deltaTime;
                }
                else if (timeRemaining <= 0)
                {
                    playerCanMove = false;
                    pauseTimer = 2f;
                }
            }
            string halfText;
            if (numHalfs >= 2 && timeRemaining <= 0 && redScore.text != blueScore.text)
            {
                halfText = "Game Over";
                gameOver = true;
            }
            else if(numHalfs >= 2 && timeRemaining <= 0 && blueScore.text == redScore.text) {
                halfText = "Overtime";
            }
            else
            {
                halfText = "Round " + numHalfs;
            }
            half.text = halfText;
            string timeText = minutes.ToString("00") + " : " + seconds.ToString("00");
            gameTimer.text = timeText;
        }

        if (!playerBlue.GetComponent<playerMovement>().canHold)
        {
            blueBallText.text = "Blue Ball";
        } else if (!playerRed.GetComponent<secondPlayerMovement>().canHold)
        {
            redBallText.text = "Red Ball";
        } else
        {
            blueBallText.text = "";
            redBallText.text = "";
        }
    }
    public void restartGame()
    {
        
        Invoke("Restart", 0f);
        
    }

    void secondHalf()
    {
        timeRemaining = TIME_REMAINING;
        resetPosition();
    }

    void resetPosition()
    {
        playerRed.GetComponent<secondPlayerMovement>().resetPosition();
        playerBlue.GetComponent<playerMovement>().resetPosition();
        ball.GetComponent<ballBehavior>().resetState();
    }
}
