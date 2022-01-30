using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetect : MonoBehaviour
{
    public MechanicManager managerColl;
    void OnCollisionEnter2D(Collision2D player) {
        if (player.gameObject.tag == "Trap") {
            managerColl.gameMood = 1;
        }

        if (player.gameObject.tag == "Revert") {
            managerColl.gameMood = 0;
        }

        if (player.gameObject.tag == "NextLevel") {
            managerColl.level++;
        }

        if (player.gameObject.tag == "Fail") {
            managerColl.scene = 1;
        }

        if (player.gameObject.tag == "Bad") {
            managerColl.textline = 7;
            managerColl.choice.SetActive(false);
        }

        if (player.gameObject.tag == "Good") {
            managerColl.textline = 6;
            managerColl.choice.SetActive(false);
        }

        if (player.gameObject.tag == "Trap" && managerColl.level == 0) {
            managerColl.textline = 1;
        }

        if (player.gameObject.tag == "NPC" && managerColl.level == 0) {
            managerColl.textline = 2;
            managerColl.npc = 1;
        }

        if (player.gameObject.tag == "NPC" && managerColl.level == 1) {
            managerColl.textline = 3;
            managerColl.npc = 2;
        }

        if (player.gameObject.tag == "NPC" && managerColl.level == 2) {
            managerColl.textline = 4;
            managerColl.npc = 3;
        }

        if (player.gameObject.tag == "NextLevel" && managerColl.level == 3) {
            managerColl.textline = 5;
        }

        if (player.gameObject.tag == "Choice") {
            managerColl.choice.SetActive(false);
        }
    }
}
