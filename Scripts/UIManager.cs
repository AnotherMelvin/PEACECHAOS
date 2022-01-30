using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Animator transitionClose;
    private Animator creditsAnimator;
    private GameObject creditsUI;
    public GameObject PauseMenuUI;
    [SerializeField] Slider volumeSlider;

    void Start()
    {
        if (!PlayerPrefs.HasKey("musicVolume")) 
        {
            PlayerPrefs.SetFloat("musicVolume", 1f);
            Load();
        } else
        {
            Load();
        }

        if (SceneManager.GetActiveScene().name == "Main Menu")
        {
            Debug.Log("you're in main menu!");
            creditsUI = GameObject.Find("Credits UI");
            //creditsAnimator = creditsUI.GetComponent<Animator>();
            creditsUI.SetActive(false);
        } else
        {
            Debug.Log("everything credits related is null");
            creditsAnimator = null;
            creditsUI = null;
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }

    public void StartGame()
    {
        StartCoroutine(TransitionNextScene());
    }

    public void ExitGame()
    {
        Debug.Log("Game Exited");
        Application.Quit();
    }

    public void OpenCredits()
    {
        creditsUI.SetActive(true);
    }

    public void CloseCredits()
    {
        StartCoroutine(TranstionCreditsClose());
    }

    public void MainMenu()
    {
        StartCoroutine(TransitionMainMenu());
    }

    public void Restart()
    {
        StartCoroutine(TransitionRestartScene());
    }

    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        
        if (Time.timeScale < 1) Time.timeScale = 1;
    }

    IEnumerator TransitionRestartScene()
    {
        transitionClose.SetTrigger("Transition");

        yield return new WaitForSecondsRealtime(1f);

        if (Time.timeScale < 1) Time.timeScale = 1;
        SceneManager.LoadScene("Game Scene");
    }

    IEnumerator TransitionMainMenu()
    {
        transitionClose.SetTrigger("Transition");

        yield return new WaitForSecondsRealtime(1f);

        if (Time.timeScale < 1) Time.timeScale = 1;
        SceneManager.LoadScene("Main Menu");
    }

    IEnumerator TransitionNextScene()
    {
        transitionClose.SetTrigger("Transition");

        yield return new WaitForSecondsRealtime(1f);

        if (Time.timeScale < 1) Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator TranstionCreditsClose()
    {
        //creditsAnimator.SetTrigger("Transition");

        yield return new WaitForSecondsRealtime(0f);

        if (Time.timeScale < 1) Time.timeScale = 1;
        creditsUI.SetActive(false);
    }
}
