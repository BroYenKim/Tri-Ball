using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoringBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    public int point;
    public GameObject ball;
    public GameObject scoreUI;
    public GameObject playerRed;
    public GameObject playerBlue;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "ball")
        {
            if(gameObject.tag == "bluePoint") {
                playerBlue.GetComponent<playerMovement>().scored = true;
                FindObjectOfType<audioManager>().Play("score");
            }
            else if(gameObject.tag == "redPoint") {
                playerRed.GetComponent<secondPlayerMovement>().scored = true; 
                FindObjectOfType<audioManager>().Play("score");
            }
            scoreUI.GetComponent<scoreUI>().addPoint(point);
        }
    }

}
