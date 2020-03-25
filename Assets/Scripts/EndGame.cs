using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject gameOverText;
    public GameObject restartButton; 



    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.x) >= 8)
        {
            freezeMovement();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Obstacle"))
        {
            freezeMovement();
        }
    }
    void freezeMovement()
    {
        GetComponent<PlayerMovement>().enabled = false; //Disable dieu khien
        gameOverText.SetActive(true);
        restartButton.SetActive(true);
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll; //disable any movement of the object
    }
}
