using UnityEngine;
using System.Collections;
using System;

public class LevelOver : MonoBehaviour {

    public GameObject endingPanel;
    public GameObject LvlScore;
    public GameObject CoinSum;
    public Transform EndPanel;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "kissa")
        {

            Invoke("endLevel", 3.5f);
            endLevel();
        }
      

  
    }


        void endLevel()
    {
        endingPanel.SetActive(true);
        LvlScore.transform.SetParent(EndPanel);
        CoinSum.transform.SetParent(EndPanel);
    }
    

    
}
