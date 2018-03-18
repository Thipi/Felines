using UnityEngine;
using System.Collections;

public class CAT1LevelSelection : MonoBehaviour {

    public string[] LevelTags;

    public GameObject[] locks;
    public GameObject[] lvlButtons;
    public bool[] levelUnlocked;

    public bool isPressed;



	// Use this for initialization
	void Start () {

        for (int i = 0 ; i < LevelTags.Length; i++)
        {
            if(PlayerPrefs.GetInt(LevelTags[i]) == null){
                levelUnlocked[i] = false;
        }
            else if (PlayerPrefs.GetInt(LevelTags[i]) == 0)
            {
                levelUnlocked[i] = false;
            }
            else
            {
                levelUnlocked[i] = true;
            }

            if(levelUnlocked[i])
            {
                locks[i].SetActive(false);
                lvlButtons[i].SetActive(true);
            }
        }


      
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void LoadFirstLevel()
    {
        Application.LoadLevel(2);
    }

    public void LoadSecondLevel()
    {
           
            Application.LoadLevel(3);
        
    }

    public void LoadThirdLevel()
    {
        Application.LoadLevel(4);
    }

    public void LoadFourthLevel()
    {
        Application.LoadLevel(5);
    }

    public void LoadFifthLevel()
    {
        Application.LoadLevel(6);
    }
    

    public void LoadLevelSelection()
    {
        Application.LoadLevel(1);
    }


       
}
