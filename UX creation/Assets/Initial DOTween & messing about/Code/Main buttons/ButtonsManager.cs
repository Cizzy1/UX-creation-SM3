using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsManager : MonoBehaviour
{
    [Header("Screen gameobjects")]
    public GameObject MainScreen;
    public GameObject OptionsScreen;

    public void Play(){
        // Load level select screen
        Debug.Log("Loaded level select");
        SceneManager.LoadScene("Game");
    }

    public void Options(){
        Debug.Log("Loaded options");
        // Hide main menu
        MainScreen.SetActive(false);

        OptionsScreen.SetActive(true);
    }

    public void Quit(){
        Application.Quit();
        Debug.Log("Quit game");
    }

    public void Back(){
        MainScreen.SetActive(true);
        OptionsScreen.SetActive(false);
    }

    public void MenuLoad(){
        SceneManager.LoadScene("Menu");
    }
}
