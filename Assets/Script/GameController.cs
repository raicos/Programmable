using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public bool gameState;
    

    // Start is called before the first frame update
    void Start()
    {
        gameState = false;
        SceneManager.LoadScene("GameStartScene", LoadSceneMode.Additive);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void gameOver()
    {
        gameState = false;
        SceneManager.LoadScene("GameOverScene", LoadSceneMode.Additive);
        GameObject obj = GameObject.Find("Score");
        ScoreScript score = obj.GetComponent<ScoreScript>();
        naichilab.RankingLoader.Instance.SendScoreAndShowRanking(score.score);

    }
}
