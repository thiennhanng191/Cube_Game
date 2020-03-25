using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset; //Vector3 stores 3 floats

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset; // transform refers to the transform of the current object that the script is on (the camera) => refer to the position of the camera 
        //plus offset to put the camera behind the player
    }
}
