using UnityEngine;
using System.Collections;

public class healthcounter : MonoBehaviour {

    public GameObject health1;
    public GameObject health2;
    public GameObject health3;
    

    

	// Use this for initialization
	void Start () {
        health1.SetActive(true);
        health2.SetActive(true);
        health3.SetActive(true);
        
	
	}
	
	// Update is called once per frame
	void Update () {
        PlayerPrefs.GetInt("healthcounter");
	
        {
            putousPuhdistus countHealth = GetComponent<putousPuhdistus>();
            if(PlayerPrefs.GetInt("healthcounter") == 2)
            {
                health1.SetActive(false);
            }
            if (PlayerPrefs.GetInt("healthcounter") == 1)
            {
                health2.SetActive(false);
            }
            if(PlayerPrefs.GetInt("healthcounter") == 0)
            {
                health3.SetActive(false);
            }
        }
	}
}
