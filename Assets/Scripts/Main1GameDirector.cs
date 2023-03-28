using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main1GameDirector : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject GameOverText;

    // Start is called before the first frame update
    void Start()
    {
        GameOverText.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);
   
    }

    // Update is called once per frame

    public void GameOver()
    {
        // GameOverテキストの表示
        GameOverText.SetActive(true);
        button1.SetActive(true);
        button2.SetActive(true);
    }

    void Update()
    {

    }

}
