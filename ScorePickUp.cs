using UnityEngine;
using System.Collections;

public class ScorePickUp : MonoBehaviour {

    public int pointsToAdd;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<CatControllerCAT1>() == null)
        {
            return;
        }
        ScoreManager.AddPoints(pointsToAdd);
    }
}
