using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool playing = true;
    private UIManager uIManager;
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip gameMusic;

    [SerializeField]
    private AudioClip endMusic;

    [SerializeField]
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void EndGame() 
    {
        playing = false;
        uIManager.ShowEndScreen();
        audioSource.Stop();
        audioSource.loop = false;
        audioSource.clip = endMusic;
        audioSource.Play();
    }

    public bool isPlaying()
    {
        return playing;
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UpdateScore()
    {
        score++;
        uIManager.UpdateScore(score);
    }
}
