using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MechanicManager : MonoBehaviour {
    public int gameMood;
    // gameMood = 0 -> White Background (Peace)
    // gameMood = 1 -> Dark Background (Chaos)
    public int level;
    // level = 0 -> Level 1
    // level = 1 -> Level 2
    // level = 2 -> Level 3
    // level = 3 -> Level 4
    public int scene;
    // scene = 0 -> Game Scene
    // scene = 1 -> GameOver
    public int textline; // 7 textline total
    public int reset;
    public int npc;
    public GameObject levelOne;
    public GameObject levelTwo;
    public GameObject levelThree;
    public GameObject levelFour;
    public GameObject NPCTag1;
    public GameObject NPCTag2;
    public GameObject NPCTag3;
    public GameObject wall;
    public GameObject choice;
    public GameObject pauseMenuUI;

    void Start() {
        gameMood = 0;
        level = 0;
        reset = 1;
        scene = 0;
        textline = 0;
        npc = 0;

        wall.SetActive(true);
        choice.SetActive(true);
        NPCTag1.SetActive(true);
        NPCTag2.SetActive(true);
        NPCTag3.SetActive(true);
    }

    void Update() {
        
        switch (level) {
            case 0:
                levelOne.SetActive(true);
                levelTwo.SetActive(false);
                levelThree.SetActive(false);
                levelFour.SetActive(false);
                break;
            
            case 1:
                levelOne.SetActive(false);
                levelTwo.SetActive(true);
                break;

            case 2:
                levelTwo.SetActive(false);
                levelThree.SetActive(true);
                break;

            case 3:
                levelThree.SetActive(false);
                levelFour.SetActive(true);
                break;
        }

        switch (scene) {
            case 1:
                SceneManager.LoadScene("GameOver");
                scene = 0;
                break;
        }

        switch (npc) {
            case 1:
                NPCTag1.SetActive(false);
                break;

            case 2:
                NPCTag2.SetActive(false);
                break;

            case 3:
                NPCTag3.SetActive(false);
                break;
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0;
        }
    }
}

