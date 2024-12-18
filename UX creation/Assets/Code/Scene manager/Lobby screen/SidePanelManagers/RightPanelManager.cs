using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RightPanelManager : MonoBehaviour
{
    // First button = Settings
    public void OpenSettingsMenu(){
        // This will open the settings scene on top of the current scene
        SceneManager.LoadScene("SettingsScreen", LoadSceneMode.Additive);
    }

    // 2nd button = Report
    [Header("Report Player")]
    public GameObject ReportPanel;
    public void OpenPlayerReport(){
        ReportPanel.SetActive(true);
    }

    public void ClearReport(){
        // Clear the contents of the report panel
        ReportPanel.transform.Find("PlayerNameInput").GetComponent<TMP_InputField>().text = "";
        ReportPanel.transform.Find("DescriptionInput").GetComponent<TMP_InputField>().text = "";
    }

    // 3rd button = TOS
    [Header("Terms of service")]
    public GameObject TOSPanel;
    public void OpenTOS(){
        // Open the TOS panel
        TOSPanel.SetActive(true);
    }

    // 4th button = Support (website)
    public void OpenSupport(){
        Application.OpenURL("https://fdagames.itch.io");
    }

    // 5th button = Credits
    [Header("Credits")]
    public GameObject CreditsPopup;
    public void OpenCredits(){
        CreditsPopup.SetActive(true);
    }

    // 6th button = Exit game

    [Header("Exit game properties")]
    public GameObject ExitGamePopup;
    public void OpenExitGame(){
        // Open the popup
        ExitGamePopup.SetActive(true);
    }

    public void CloseExitPopup(){
        // Close the popup
        ExitGamePopup.GetComponent<CloseGO>().CloseOBJ();
    }

    public void QuitApp(){
        Debug.Log("Application closed");
        Application.Quit();
    }
}