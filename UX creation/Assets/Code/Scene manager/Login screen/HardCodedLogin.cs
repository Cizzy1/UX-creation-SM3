using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class HardCodedLogin : MonoBehaviour
{
    // Need to have references to these and as ugly as it is I wish I could just GameObject.Find("")
    // but unfortunetly that does work with disabled objects. So there will be many references below.
    
    [Header("Click to start properties")]
    public GameObject ClickToStartCanvas;
    public GameObject FadeBackground;

    [Header("Login screen")]
    public GameObject LoginCanvas;

    [Header("Forgotten pass screen")]
    public GameObject ForgottenCanvas;

    // Could call a animation script that will basic animations

    void Update(){

        // This will check for input of the sort for the click to start screen
        if(Input.anyKey){
            ClickToStart();
        }
    }

    public void ClickToStart(){
        // Move over to the Login screen

        // Fade in the static background
        FadeBackground.GetComponent<SimpleAnimations>().FadeBack();

        // Load in the Login screen
        LoginCanvas.SetActive(true);

        // Main change is the click to start. Need to remove it
        ClickToStartCanvas.SetActive(false);
    }

    public void SignUp(){

    }

    public void ForgotPass(){
        // Disable the login screen

        // Enable the forgotten pass
        ForgottenCanvas.SetActive(true);
    }

    //------------------------------------------------------
}
