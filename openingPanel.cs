using UnityEngine;
using System.Collections;

public class openingPanel : MonoBehaviour {

    public GameObject guidepanel1;
    bool isActive = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "kissa")
        {
            guidepanel1.SetActive(true);
        }

    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "kissa")
        {
            guidepanel1.SetActive(false);
        }
    }


    
}
