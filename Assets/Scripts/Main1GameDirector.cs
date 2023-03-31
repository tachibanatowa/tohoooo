using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main1GameDirector : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject GameOverText;

    //private PlayerBullet Player;
    //private EnemySpawn Enemy;

     //private PlayerBullet Instance = new();

    //private PlayerBullet Play = new();

    int _toubatusuu;

    public float _ToubatuPercent;
    public float _JituToubatu;

    // Start is called before the first frame update
    void Start()
    {
        

        GameOverText.SetActive(false);
        button1.SetActive(false);
        button2.SetActive(false);

        _ToubatuPercent=0.5f; 
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


   

    //public void GameEnd()
    //{
    //    _JituToubatu = (float)Player._EnemyNum / Enemy._EnemyCount;

    //    if (Enemy._EnemyConditions == Enemy._EnemyCount)

    //    {
    //        GetComponent<Main1GameDirector>().GameOver();

    //    }
    //}


 }


