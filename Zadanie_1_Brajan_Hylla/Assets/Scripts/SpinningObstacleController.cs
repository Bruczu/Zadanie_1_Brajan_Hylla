using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningObstacleController : MonoBehaviour
{
    public bool clockwise; 
    public float spin_speed;
    void Update()
    {
        if (clockwise) {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, transform.localEulerAngles.z + 20 * Time.deltaTime * spin_speed);
        }
        else
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, transform.localEulerAngles.z + 20 * Time.deltaTime * -1 * spin_speed);
        }
    }
}
