using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour
{
    float time;

    // 手の画像
    public Sprite hand_crash;

    // 手の状態
    public bool handState;

    SpriteRenderer handImage;

    AudioSource se;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        handState = true;
        handImage = gameObject.GetComponent<SpriteRenderer>();

        se = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float random = Random.Range(2.0f, 10.0f);
        moveHand(random);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            removeHand();
            se.PlayOneShot(se.clip);
        }
    }

    void moveHand(float speed){
        time += Time.deltaTime;
        float dx = time * speed ;
        if (!handState){
            dx = 0;
        }
        this.transform.position += Vector3.right * dx;
    }

    void removeHand(){
        handState = false;
        handImage.sprite = hand_crash;
        Destroy(gameObject, 0.5f);

        GameObject target = GameObject.Find("Target(Clone)");

        HandGeneratorScript hgs = GameObject.Find("HandGenerator").GetComponent<HandGeneratorScript>();
        hgs.nothingFlag = true;

        if (target.GetComponent<TargetScript>().targetState)
        {
            GameObject gc = GameObject.Find("GameController");
            GameController script = gc.GetComponent<GameController>();
            script.gameOver();
        }
        else
        {
            Destroy(target, 0.5f);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D col){
        Destroy(gameObject);
        Destroy(col.gameObject);
        TargetScript target = col.gameObject.GetComponent<TargetScript>();
        if (!target.targetState)
        {
            GameObject gc = GameObject.Find("GameController");
            GameController script = gc.GetComponent<GameController>();
            script.gameOver();
        }
        HandGeneratorScript hgs = GameObject.Find("HandGenerator").GetComponent<HandGeneratorScript>();
        hgs.nothingFlag = true;
    }
}
