using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Padoru : MonoBehaviour
{

    public Rigidbody2D rigidBody;
    public float speed = 6f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.velocity = new Vector2(0, speed);
        }
    }


}
