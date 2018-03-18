using UnityEngine;
using System.Collections;

public class endingPanelScript : MonoBehaviour {

    public GameObject paw1;
    public GameObject paw2;
    public GameObject paw3;

	// Use this for initialization
	void Start () {
        if (ScoreManager.score > 50){
            paw1.SetActive(true);
            coinManager.AddCoins(3);
        }
        if(ScoreManager.score > 100)
        {
            paw2.SetActive(true);
            coinManager.AddCoins(3);
        }
        if(ScoreManager.score > 150)
        {
            paw3.SetActive(true);
            coinManager.AddCoins(3);
        }

        resetScore();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void resetScore()
    {
        ScoreManager.Reset();
    }
}
