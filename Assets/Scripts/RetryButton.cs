using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{

    [SerializeField]
    Button testButton;

    void Start()
    {
        
    }

    public void RetryButtonOnClick()
    {
        GetComponent<Button>().interactable = false;
        SceneManager.LoadScene("MainGameScene1");
    }

}
