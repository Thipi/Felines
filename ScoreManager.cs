using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static int score;
    Text text;


    void Start ()
    {
        PlayerPrefs.SetInt("Level2", 1); //Unlocks the next level
        PlayerPrefs.SetInt("Level_score", score);
        text = GetComponent<Text>();
        score = PlayerPrefs.GetInt("Level_score", score);
    }

    void Update()
    {
        if(score < 0)
        {
            score = 0;
        }
        text.text = "" + score;
    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }

    public static void Reset()
    {
        score = 0;
    }
}
