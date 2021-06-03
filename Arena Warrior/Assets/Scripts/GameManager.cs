using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject music1, music2, music3;
    public GameObject game, fightButton, fightIcon;
    int whatToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Fight()
    {
        whatToSpawn = Random.Range(1, 4);

        switch (whatToSpawn)
        {
            case 1:
                Instantiate(music1, transform.position, Quaternion.identity);
                break;

            case 2:
                Instantiate(music2, transform.position, Quaternion.identity);
                break;

            case 3:
                Instantiate(music3, transform.position, Quaternion.identity);
                break;

        }

        fightButton.SetActive(false);
        game.SetActive(true);
        fightIcon.SetActive(true);
        
    }
}
