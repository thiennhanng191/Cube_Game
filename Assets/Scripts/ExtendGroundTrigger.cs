using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtendGroundTrigger : MonoBehaviour
{
    public GameObject groundOne;
    public GameObject groundTwo;

    private int count = 0; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (count % 2 == 0)
            {
                ExtendGroundOne();
            }
            else
            {
                ExtendGroundTwo();
            }
            count++;
            var triggerZPos = transform.position.z;
            triggerZPos += 200;

            transform.position = new Vector3(0, 0, triggerZPos);
            
        }
    }

    void ExtendGroundOne()
    {
        var groundOneZPos = groundOne.transform.position.z;
        groundOneZPos += 400;
        groundOne.transform.position = new Vector3(0, 0, groundOneZPos);
    }
    void ExtendGroundTwo()
    {
        var groundTwoZPos = groundTwo.transform.position.z;
        groundTwoZPos += 400;
        groundTwo.transform.position = new Vector3(0, 0, groundTwoZPos);
    }
}
