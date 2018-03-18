using UnityEngine;
using System.Collections;

public class putousPuhdistus : MonoBehaviour {

    public bool isDead = false;
    public int coinPenalty;

    // Use this for initialization
    void Start() {
       
    }
	// Update is called once per frame
	void Update () {
	
	}

    public void OnTriggerEnter2D (Collider2D other)
    {
        
        if (other.tag == "kissa")
        {
            Application.LoadLevel(Application.loadedLevel);
            ScoreManager.Reset();
            coinManager.AddCoins(-coinPenalty);
            IsDead();
            

        }
        //if (other.tag == "pikkukaveri")
        //{
        //  PelaajanTerveys kaveriPutosi = other.GetComponent<PelaajanTerveys>();
        // kaveriPutosi.makeDead(); //kutsutaan PelaajanTerveys Scriptistä makeDead komentoa. Box Colliderissa Trigger päällä. 
        //}
        //else 
       
       
    }

    public void IsDead()
    {
        isDead = true;
    }
}
