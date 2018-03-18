using UnityEngine;
using System.Collections;

public class CoinPickUp : MonoBehaviour {

    public int coinsToAdd;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<CatControllerCAT1>() == null)
        {
            return;
        }

        coinManager.AddCoins(coinsToAdd);

        Destroy(gameObject);
    }
}
