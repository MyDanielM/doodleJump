using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR.WSA.Input;

public class DefeatMenu : MonoBehaviour
{
    public Text score;
    public void tryAgain()
    {
        SceneManager.LoadScene("Play");
    }
    public void Menu()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Start()
    {
        score.text = "Вы заработали " + scoreHolder.Score + " очков!";
    }
}
