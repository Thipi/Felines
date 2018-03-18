using UnityEngine;
using System.Collections;

public class waterKills : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "kissa")
        {

            ScoreManager.AddPoints(-10);
        }
    }
}
