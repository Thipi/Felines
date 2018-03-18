using UnityEngine;
using System.Collections;

public class LevelChanger : MonoBehaviour {

    public string LevelTag;

	// Use this for initialization
	void Start () {
       // DeleteAll();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

public void LoadLevelSelection()
    {
        PlayerPrefs.SetInt(LevelTag, 1);
        Application.LoadLevel(1);
    }

  // void DeleteAll()
    //{
      //  PlayerPrefs.DeleteAll();
    //}
}
