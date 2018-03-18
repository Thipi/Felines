using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class coinManager : MonoBehaviour {

    public static int CoinSum;
    Text sum;

	// Use this for initialization
	void Start () {

        sum = GetComponent<Text>();
        PlayerPrefs.SetInt("Coins", CoinSum);
        CoinSum = PlayerPrefs.GetInt("Coins", CoinSum);
        
	
	}
	
	// Update is called once per frame
	void Update () {

        if(CoinSum < 0)
        {
            CoinSum = 0;
        }
        
        sum.text = "" + CoinSum;
        
	
	}

    public static void AddCoins(int coinsToAdd)
    {
        CoinSum += coinsToAdd;
    }


}
