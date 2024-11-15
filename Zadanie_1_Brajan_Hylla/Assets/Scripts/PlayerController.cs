using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rigidbody;
    public Transform startPoint;
    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        Debug.Log("");
    }
    void Update()
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
        if (transform.position.y <= -1)
        {
            transform.position = startPoint.position;
            rigidbody.velocity = Vector3.zero;
        }
    }
}
