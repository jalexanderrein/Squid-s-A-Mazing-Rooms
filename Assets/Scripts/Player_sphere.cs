using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Player_sphere : MonoBehaviour
{
    Rigidbody rb;
//    public int ballspeed = 1;
    //initiating variables

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float Hmove = Input.GetAxis("Horizontal");

        float Vmove = Input.GetAxis("Vertical");

        Vector3 ballmove = new Vector3(Hmove, 0.0f, Vmove);

        rb.AddForce(ballmove);
    }
}