using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Padoru : MonoBehaviour
{

    public Rigidbody2D rigidBody;
    public float speed = 6f;

    [SerializeField]
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameManager.isPlaying())
            return;

        if(Input.GetKeyDown(KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            rigidBody.velocity = new Vector2(0, speed);
        }

        if(transform.position.x < -12f || transform.position.y < -6f)
        {
            gameManager.EndGame();
        }
    }


}
