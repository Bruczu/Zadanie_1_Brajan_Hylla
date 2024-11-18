using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObstacleController : MonoBehaviour
{
    public bool isMovingRight;
    public float speed_obstacle;
    public Transform Obstacle_Right;
    public Transform Obstacle_Left;
    void Update()
    {
        if (isMovingRight)
        {
            transform.Translate(1 * Time.deltaTime * speed_obstacle, 0, 0);
            if (transform.position.x > Obstacle_Right.position.x)
            {
                isMovingRight = false;
            }
        }
        else
        {
            transform.Translate(-1 * Time.deltaTime * speed_obstacle, 0, 0);
            if (transform.position.x < Obstacle_Left.position.x)
            {
                isMovingRight = true;
            }

        }
    }
}
