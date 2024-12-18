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
        // Whos gonna buy me this?
        Application.OpenURL("https://configurator.porsche.com/en-GB/model/992850?options=AVK.5XK.ASR.8VH.5DC.00480.2UH.9VL.24901.VF3.2C6.A1.6A8.24906.QR9.1LX.8JU.1NM.24905.VW7.KA2.ASV.AGT.6RD.25889.56R.BAR.42.VC2.24907.7M8.UP3.04I.FX8.QQ2.7V3.QV3.7UG.7I2.9JA.6F4.9WT.QH1.1P0.7AL.4UF.FM7.1T2.9AD.A8G.0TC.5MK.0P9.VL2.E1T.8T1.6Q5.Q1K.K8C.6E1.0NB.2W6.6XA.7K3.0I1.0N5.2D0.UI2.7HC.G1C.1BV.3FF.6NN.1X2.GH3.5KS.D2Q.1N3.J2B.9P3.IW3.1XQ.2V1.1G8.8LH&variants=00480_4A.24901_1H.24905_1H.24906_1H.24907_1H.25889_1H.AGT_D7.ASR_24.AVK_4A.BAR_4A");
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