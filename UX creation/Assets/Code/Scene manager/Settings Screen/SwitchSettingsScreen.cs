using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SwitchSettingsScreen : MonoBehaviour
{
    [Header("List of possible screens")]
    // 0-4 index. There is 5 screens but index starts always at 0
    public GameObject[] Screens;

    [Header("List of current buttons")]
    public GameObject[] SideButtons;
    
    [Header("Sprites")]
    public Sprite NormalBTN;
    public Sprite SelectedBTN;

    void Start(){
        ChangeScreen(0);
    }

    // Button press
    public void ChangeScreen(int index){
        ClearStatus();

        // Need Set button icon
        SideButtons[index].GetComponent<Image>().sprite = SelectedBTN;

        // Disable said button .interactable
        SideButtons[index].GetComponent<Button>().interactable = false;

        // Open the correct screen
        Screens[index].SetActive(true);
    }

    void ClearStatus(){
        // For Loop

        for (int i = 0; i < Screens.Length; i++)
        {
            // Set every button sprite to normal
            SideButtons[i].GetComponent<Image>().sprite = NormalBTN;

            // Set every button to interactable
            SideButtons[i].GetComponent<Button>().interactable = true;

            // Set all of the screens to inactive
            Screens[i].SetActive(false);
            
        }
    }

    // Close the Settings screen
    public void CloseSettings()
    {
        SceneManager.UnloadSceneAsync("SettingsScreen");
    }
}
