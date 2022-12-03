using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pillar : MonoBehaviour
{
    public float speed = 5f;
    public GameObject player;
    public GameManager gameManager;
    private bool updated = false;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        player = GameObject.Find("Padoru");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0);

        if(transform.position.x < -12f)
        {
            Destroy(gameObject);
        }

        if(gameManager.isPlaying() && transform.position.x < player.transform.position.x && !updated)
        {
            gameManager.UpdateScore();
            updated = true;
        }
    }
}
