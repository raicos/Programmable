using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{

    GameController script;

    // Start is called before the first frame update
    void Start()
    {
        GameObject gc = GameObject.Find("GameController");
        script = gc.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            script.gameState = true;
            SceneManager.UnloadScene("GameStartScene");
        }
    }
}
