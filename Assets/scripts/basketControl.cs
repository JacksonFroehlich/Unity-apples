using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class basketControl : MonoBehaviour
{
    public Transform left;
    public Transform right;
    public Text scoreText;
    public Text livesText;
    private int score;
    public int lives;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "Lives: " + lives;
    // transform.position = Camera.main.ScreenToWorldPoint(/*new Vector2*/ (Input.mousePosition /*.x, transform.position.y*/ ));
    // Camera.main.transform.position = transform.position;

    transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, transform.position.y, transform.position.z);
                 if (transform.position.x < left.position.x)
                    {
                        transform.position= new Vector3(left.position.x, transform.position.y, transform.position.z);
                     }
                 else if(transform.position.x > right.position.x)
                    {
                        transform.position = new Vector3(right.position.x, transform.position.y, transform.position.z);
                    }   
       
        
        //Camera.main.transform.position = transform.position;

        if(lives <= 0)
        {
            if(PlayerPrefs.GetInt("score") < score)
            {
                PlayerPrefs.SetInt("score", score);
            }
            SceneManager.LoadScene (sceneName: "MainMenu");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("colligisds");
        Destroy(collision.gameObject);
        score += 10;
        scoreText.text = "Score: " + score;
    }
}
