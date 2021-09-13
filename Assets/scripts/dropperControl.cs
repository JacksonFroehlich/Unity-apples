using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropperControl : MonoBehaviour
{
    public Transform left;
    public Transform right;
    private bool moveLeft;
    private Vector3 target;
    public float speed;
    public float time;
    private float lastTime;
    public Object apple;
    // Start is called before the first frame update
    void Start()
    {
        lastTime = time;
        Debug.Log("prisids");
       
        moveLeft = true;
        target = new Vector3(left.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(target == transform.position)
        {
            if (moveLeft)
            {
                target = new Vector3(right.position.x, transform.position.y, transform.position.z);
            }
            else
            {
                target = new Vector3(left.position.x, transform.position.y, transform.position.z);
            }
            moveLeft = !moveLeft;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
    private void FixedUpdate()
    {
        if(time <= 0)
        {
            Instantiate(apple, transform.position, Quaternion.identity);
            time = lastTime - 3;
            if(lastTime < 30)
            {

            }
            else
            {
                lastTime = lastTime - 3;
            }
            if(speed < 30)
            {
                speed++;
            }
        }
        else
        {
            time--;
        }
    }


}
