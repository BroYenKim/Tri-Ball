using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballBehavior : MonoBehaviour
{
    public GameObject playerBlue;
    public GameObject playerRed; 

    Vector3 START_POSITION = new Vector3(0, 105, 0);
    Vector3 blueOffense = new Vector3(-44, 104, -11);
    Vector3 redOffense = new Vector3(44, 104, 11);
    public Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void resetState()
    {
        transform.position = START_POSITION;
        rigidBody.velocity = Vector3.zero;
    }

    void Update() {
        if(playerBlue.GetComponent<playerMovement>().didTurnover || playerBlue.GetComponent<playerMovement>().scored) {
            transform.position = redOffense;
            rigidBody.velocity = Vector3.zero;
            playerBlue.GetComponent<playerMovement>().didTurnover = false;
            playerBlue.GetComponent<playerMovement>().scored = false;
        }
        else if(playerRed.GetComponent<secondPlayerMovement>().didTurnover || playerRed.GetComponent<secondPlayerMovement>().scored) {
            transform.position = blueOffense;
            rigidBody.velocity = Vector3.zero;
        }
    }
}
