using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Play");
    }

    public bool isPaused = false;
    public Text btnPause;

    public void PauseGame()
    {
        if (!isPaused)
        {
            Time.timeScale = 0f;
            isPaused = true;
            btnPause.text = "Resume";
        }
        else if (isPaused)
        {
            Time.timeScale = 1f;
            isPaused = false;
            btnPause.text = "Pause";
        }
    }
}
