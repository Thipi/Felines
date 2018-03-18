using UnityEngine;
using System.Collections;
using System;

public class SceneManager : MonoBehaviour {

    public int score = ScoreManager.score;

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("Level2", 1); //Unlocks the next level
        PlayerPrefs.SetInt("Level_score", score);


    }
	
	// Update is called once per frame

}
