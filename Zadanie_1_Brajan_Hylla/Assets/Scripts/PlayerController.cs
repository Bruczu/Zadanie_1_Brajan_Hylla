using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public float checkpoint;
    public int zebranePunkty;
    public Rigidbody rigidbody;

    public Transform startPoint;
    public Transform checkpoint_1;
    public Transform checkpoint_2;
    public Transform checkpoint_3;
    public Transform checkpoint_4;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        checkpoint = 1;
        Debug.Log(checkpoint);
    }

    void Update()
    {
        if (checkpoint == 1 || checkpoint == 5)
        {
            if (Input.GetAxis("Horizontal") != 0)
            {
                float directionHorizontal = Input.GetAxis("Horizontal");
                rigidbody.AddForce(directionHorizontal * Time.deltaTime * speed, 0, 0, ForceMode.Impulse);
            }
            if (Input.GetAxis("Vertical") != 0)
            {
                float directionVertical = Input.GetAxis("Vertical");
                rigidbody.AddForce(0, 0, directionVertical * Time.deltaTime * speed, ForceMode.Impulse);
            }
        }
        if (checkpoint >= 2 & checkpoint <= 4)
        {
            if (Input.GetAxis("Horizontal") != 0)
            {
                float directionHorizontal = Input.GetAxis("Horizontal");
                rigidbody.AddForce((directionHorizontal * Time.deltaTime * speed) * -1, 0, 0, ForceMode.Impulse);
            }
            if (Input.GetAxis("Vertical") != 0)
            {
                float directionVertical = Input.GetAxis("Vertical");
                rigidbody.AddForce(0, 0, (directionVertical * Time.deltaTime * speed) * -1, ForceMode.Impulse);
            }
        }

        if (transform.position.y <= -1)
        {
            if (checkpoint == 1)
            {
                transform.position = startPoint.position;
                rigidbody.velocity = Vector3.zero;
            }
            if (checkpoint == 2)
            {
                transform.position = checkpoint_1.position;
                rigidbody.velocity = Vector3.zero;
            }
            if (checkpoint == 3)
            {
                transform.position = checkpoint_2.position;
                rigidbody.velocity = Vector3.zero;
            }
            if (checkpoint == 4)
            {
                transform.position = checkpoint_3.position;
                rigidbody.velocity = Vector3.zero;
            }
            if (checkpoint == 5)
            {
                transform.position = checkpoint_4.position;
                rigidbody.velocity = Vector3.zero;
            }
        }
    }
}
