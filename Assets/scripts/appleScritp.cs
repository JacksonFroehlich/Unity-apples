using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appleScritp : MonoBehaviour
{
    public Object player;
    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log("ssss ss king?");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("is this working?");
        if (collision.gameObject.CompareTag("Death"))
            {
            Debug.Log("why no less lives");
            GameObject.Find("player").GetComponent<basketControl>().lives--;
            }
    }
}
