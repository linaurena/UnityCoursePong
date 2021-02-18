using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public Transform paddle;
    public bool gameStarted = false;

    public Rigidbody2D rbBall;
    float posDif = 0;

    // Start is called before the first frame update
    void Start()
    {
        posDif = paddle.position.x - transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
            transform.position = new Vector3(paddle.position.x - posDif, paddle.position.y, paddle.position.z);
        if(Input.GetMouseButtonDown(0))
            {
                rbBall.velocity = new Vector2(8,8);
                gameStarted = true;
            }
        }
    }
}
