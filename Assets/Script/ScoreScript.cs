using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public double score;

    public Text scoreText;

    bool gameState;
    GameController script;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        GameObject gc = GameObject.Find("GameController");
        script = gc.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        gameState = script.gameState;

        if (gameState)
        {
            score += Time.deltaTime;
        }

        scoreText.text = "SCORE : " + score;
    }
}
