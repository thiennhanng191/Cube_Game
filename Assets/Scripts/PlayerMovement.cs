using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 700f; 
    public float sidewaysForce = 500f;
    public float upwardsForce = 300f;

    public Transform player;
    private int yposnPlayer;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    //void Update()
    void FixedUpdate() //use FixedUpdate instead of Update when dealing with Unity physics
    {
        //player = GameObject.FindWithTag("Player");

        Debug.Log(player);
        yposnPlayer = (int)player.position.y;

        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Add a force of 2000 on the z-axis

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKeyDown(KeyCode.Space) && yposnPlayer == 1)
        {
            rb.AddForce(0, upwardsForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
    }

}
