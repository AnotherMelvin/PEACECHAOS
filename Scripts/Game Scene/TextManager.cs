using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public MechanicManager managerText;
    public Text Text1;
    public Text Text2;
    public Text Text3;
    public Text Text4;

    void Start() {
        Text1.text = " ";
        Text2.text = " ";
        Text3.text = " ";
        Text4.text = " ";
    }

    void Update() {
        if (managerText.textline == 0) {
            Text1.text = " ";
            Text2.text = " ";
            Text3.text = " ";
            Text4.text = " ";
        }

        else if (managerText.textline == 1) {
            StartCoroutine("Line1");
        }

        else if (managerText.textline == 2) {
            StartCoroutine("Line2");
        }

        else if (managerText.textline == 3) {
            StartCoroutine("Line3");
        }

        else if (managerText.textline == 4) {
            StartCoroutine("Line4");
        }

        else if (managerText.level == 3) {
            StartCoroutine("Line5");
        }

        else if (managerText.textline == 6) {
            StartCoroutine("Line6");
        }

        else if (managerText.textline == 7) {
            StartCoroutine("Line7");
        }
    }

    IEnumerator Line1() {
        Text1.text = "Hi fellow, you shouldn’t be here....";
        yield return new WaitForSeconds(4f);
        managerText.textline = 0;
    }

    IEnumerator Line2() {
        Text1.text = "You still here, eh?";
        yield return new WaitForSeconds(2f);
        Text1.text = "I warn you, this place is dangerous....";
        yield return new WaitForSeconds(4f);
        Text1.text = "Don’t ever think to come back here again.";
        yield return new WaitForSeconds(2f);
        managerText.textline = 0;
    }

    IEnumerator Line3() {
        Text2.text = "You are lonely, that’s why you come here right?";
        yield return new WaitForSeconds(4f);
        Text2.text = "You are so stubborn....";
        yield return new WaitForSeconds(2f);
        managerText.textline = 0;
    }

    IEnumerator Line4() {
        Text3.text = "This world has nothing....";
        yield return new WaitForSeconds(2f);
        Text3.text = "What you search is not here.";
        yield return new WaitForSeconds(2f);
        managerText.textline = 0;
    }

    IEnumerator Line5() {
        Text4.text = "I told you to never come again to this world.";
        yield return new WaitForSeconds(4f);
        Text4.text = "But you're not listening to me...";
        yield return new WaitForSeconds(2f);
        Text4.text = "Fine, if you really want to be here, i’ll grant your wish.";
        yield return new WaitForSeconds(4f);
        Text4.text = "You will NEVER back to your world again!!";
        yield return new WaitForSeconds(4f);
        Text4.text = "Now choose your own fate...";
        yield return new WaitForSeconds(4f);
        managerText.wall.SetActive(false);
        managerText.textline = 0;
    }

    IEnumerator Line6() {
        Text4.text = "Why…";
        yield return new WaitForSeconds(2f);
        Text4.text = "Are you really…";
        yield return new WaitForSeconds(2f);
        Text4.text = "Want to forgive them?";
        yield return new WaitForSeconds(2f);
        Text4.text = "I can’t understand you…";
        yield return new WaitForSeconds(2f);
        Text4.text = "Although...";
        yield return new WaitForSeconds(2f);
        Text4.text = "I AM YOU….";
        yield return new WaitForSeconds(2f);
        managerText.textline = 0;
    }

    IEnumerator Line7() {
        Text4.text = "I knew it.";
        yield return new WaitForSeconds(2f);
        Text4.text = "Your heart is full of hatred.";
        yield return new WaitForSeconds(2f);
        Text4.text = "There’s no need to change yourself...";
        yield return new WaitForSeconds(2f);
        Text4.text = "Hehehe…";
        yield return new WaitForSeconds(2f);
        Text4.text = "Just give up already.";
        yield return new WaitForSeconds(2f);
        Text4.text = "And let your soul become DARK!";
        yield return new WaitForSeconds(2f);
        managerText.textline = 0;
    }
}
