using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TryButton : MonoBehaviour
{
    public void Retry() {
        SceneManager.LoadScene("Game Scene");
    }

    public void Back() {
        SceneManager.LoadScene("Main Menu");
    }
}
