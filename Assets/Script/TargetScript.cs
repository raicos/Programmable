using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{

    public Sprite pc;
    public Sprite phone;

    SpriteRenderer targetImage;
    public bool targetState;

    // Start is called before the first frame update
    void Start()
    {
        targetImage = gameObject.GetComponent<SpriteRenderer>();
        int random = Random.Range(0, 2);
        if(random == 0)
        {
            targetImage.sprite = pc;
            targetState = true;
        }
        else
        {
            targetImage.sprite = phone;
            targetState = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
