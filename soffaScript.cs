using UnityEngine;
using System.Collections;

public class soffaScript : MonoBehaviour {

    public GameObject soffa;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "kissa")
        {
            soffa.SetActive(true);
        }
    }
}
