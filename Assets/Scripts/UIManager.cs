using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject endScreen;

    [SerializeField]
    private Text scoreText;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowEndScreen()
    {
        endScreen.SetActive(true);
    }

    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score;
    }
}
