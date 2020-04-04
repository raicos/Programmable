using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGeneratorScript : MonoBehaviour
{
    public GameObject hand;
    float time;

    public GameObject target;

    bool gameState;
    GameController script;

    public bool nothingFlag;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        GameObject gc = GameObject.Find("GameController");
        script = gc.GetComponent<GameController>();
        nothingFlag = true;
    }

    // Update is called once per frame
    void Update()
    {
        gameState = script.gameState;

        time += Time.deltaTime;
        if (gameState)
        {
            
            if(time > 3)
            {
                time = 0;
                float generateFlag = Random.Range(0, 10);
                if (generateFlag < 8.0)
                {
                    Instantiate(hand);
                    Instantiate(target);
                    nothingFlag = false;
                }

            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Space) && nothingFlag)
                {
                    GameObject gc = GameObject.Find("GameController");
                    GameController script = gc.GetComponent<GameController>();
                    script.gameOver();
                }
            }
        }
    }
}
