using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public GameObject menu, howTP;
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = "" + PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene("Arena");
    }

    public void HowToPlay()
    {
        menu.SetActive(false);
        howTP.SetActive(true);
    }

    public void Back()
    {
        menu.SetActive(true);
        howTP.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
