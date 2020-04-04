using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceScript : MonoBehaviour
{

    HandGeneratorScript script;

    public Sprite dev_normal;
    public Sprite dev_skipping;

    public SpriteRenderer face;

    // Start is called before the first frame update
    void Start()
    {
        script = GameObject.Find("HandGenerator").GetComponent<HandGeneratorScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (script.nothingFlag)
        {
            face.sprite = dev_normal;
        }
        else
        {
            face.sprite = dev_skipping;
        }
    }
}
