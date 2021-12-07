using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreUI : MonoBehaviour
{

    public Text scoreText;
    int points;

    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = points.ToString();
    }

    public void addPoint(int point)
    {
        points += point;
    }
}
