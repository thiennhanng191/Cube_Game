using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    public static int score; 


    // Update is called once per frame
    void Update()
    {
        score = (int) (player.position.z/5);
        scoreText.GetComponent<Text>().text = score.ToString();
    }
}
