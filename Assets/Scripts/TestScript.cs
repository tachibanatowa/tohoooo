using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{

    [SerializeField]
    Button testButton;

    void Start()

    {
        
    }

    public void TestButtonOnClick()
    {
        GetComponent<Button>().interactable = false;
        Debug.Log("Test Button");
    }

}
