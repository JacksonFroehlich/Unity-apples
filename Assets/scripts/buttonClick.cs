using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttonClick : MonoBehaviour
{
    public Text highest;
    // Start is called before the first frame update
    void Start()
    {
        highest.text = "High Score: " + PlayerPrefs.GetInt("score");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void clickButton()
    {
        SceneManager.LoadScene(sceneName: "SampleScene");
    }

 
}
