using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlatformState : MonoBehaviour {

    public MechanicManager managerPlatform;
    public GameObject lightGround1;
    public GameObject lightGround2;
    public GameObject lightGround3;
    public GameObject darkGround1;
    public GameObject darkGround2;
    public GameObject darkGround3;
    public Image background;
    public Sprite lightbg, darkbg;

    void Update() {
        if (managerPlatform.gameMood == 0) {
            lightGround1.SetActive(false);
            darkGround1.SetActive(true);
            lightGround2.SetActive(false);
            darkGround2.SetActive(true);
            lightGround3.SetActive(false);
            darkGround3.SetActive(true);
            background.sprite = lightbg;
        }

        if (managerPlatform.gameMood == 1) {
            lightGround1.SetActive(true);
            darkGround1.SetActive(false);
            lightGround2.SetActive(true);
            darkGround2.SetActive(false);
            lightGround3.SetActive(true);
            darkGround3.SetActive(false);
            background.sprite = darkbg;
        }
    }
}
