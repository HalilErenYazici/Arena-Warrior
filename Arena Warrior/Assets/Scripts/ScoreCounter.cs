using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text ScoreText, ScoreTextDie;
    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = Score.ToString();
        ScoreTextDie.text = Score.ToString();
    }

    public void ReturnMenu()
    {
        if(Score > PlayerPrefs.GetInt("highscore"))
        {
            PlayerPrefs.SetInt("highscore", Score);
        }

        SceneManager.LoadScene("Menu");
    }
}
