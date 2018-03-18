using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic; //for using lists
using UnityEngine.EventSystems; //To have a direct connection to the button and to make the button work.

public class LevelManager : MonoBehaviour {
    [System.Serializable]
    public class Level
    {

        public string LevelText;
        public int Unlocked;
        public bool isInteractable;

        public Button.ButtonClickedEvent OnClickEvent;

    }
    public List<Level> LevelList;
    public GameObject levelButton;
    public Transform Spacer;

    // Use this for initialization
    void Start() {
        FillList();
        
    }

    void FillList()
    {
        foreach (var level in LevelList)
        {
            GameObject newButton = Instantiate(levelButton) as GameObject;  // Instatiating buttons to Spacer
            ButtonScript button = newButton.GetComponent<ButtonScript>(); //ref to ButtonScript
            button.LevelText.text = level.LevelText;
            //LEVEL1, LEVEL2, LEVEL3 etc.

            if (PlayerPrefs.GetInt("Level" + button.LevelText.text) == 1)
            {
                level.Unlocked = 1;
                level.isInteractable = true;
            }

            button.unLocked = level.Unlocked;
            button.GetComponent<Button>().interactable = level.isInteractable;
            button.GetComponent<Button>().onClick.AddListener(() => LoadLevels("Level1" + button.LevelText.text));

            if (PlayerPrefs.GetInt("Level" + button.LevelText.text + "Level_score") > 0)
            {
                button.star1.SetActive(true);
            }
            if (PlayerPrefs.GetInt("Level" + button.LevelText.text + "Level_score") > 50)
            {
                button.star2.SetActive(true);
            }
            if (PlayerPrefs.GetInt("Level" + button.LevelText.text + "Level_score") > 100)
            {
                button.star3.SetActive(true);
            }

                newButton.transform.SetParent(Spacer);

        }

        
        SaveAll();

        
    }

    void SaveAll()
    {
       if (PlayerPrefs.HasKey("Level1"))
        {
            return;
        }
        else
        {
            GameObject[] allButtons = GameObject.FindGameObjectsWithTag("LevelButton");
            foreach(GameObject buttons in allButtons)
            {
                ButtonScript button = buttons.GetComponent<ButtonScript>();
                PlayerPrefs.SetInt("Level" + button.LevelText.text, button.unLocked);
            }
        }
    }

    void LoadLevels(string value)
    {
        Application.LoadLevel(value);
    }

    void DeleteAll()
    {
        PlayerPrefs.DeleteAll();
    }
    }
    

