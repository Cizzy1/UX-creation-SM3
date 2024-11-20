using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class HardCodedLogin : MonoBehaviour
{
    // Need to have references to these and as ugly as it is I wish I could just GameObject.Find("")
    // but unfortunetly that does work with disabled objects. So there will be many references below.
    
    
    void Update(){

        // This will check for input of the sort for the click to start screen
        if(Input.anyKey && !Login_Open){
            ClickToStart();
        }
    }

    #region Click to start & Login

    [Header("Login screen")]
    public bool Login_Open;
    public GameObject LoginCanvas;

    [Header("Click to start properties")]
    public GameObject ClickToStartCanvas;
    public GameObject FadeBackground;

    public void ClickToStart(){
        // Move over to the Login screen

        // Login panel is open so change it to true
        Login_Open = true;

        // Fade in the static background
        FadeBackground.GetComponent<SimpleAnimations>().FadeBack();

        // Load in the Login screen
        LoginCanvas.SetActive(true);

        // Main change is the click to start. Need to remove it
        ClickToStartCanvas.SetActive(false);
    }

    public void ReturnToLogin(){
        // This will act as a controller for both X buttons on
        // the sign up screen and also the forgotten password screen

        // Disable both 
        SignUpCanvas.SetActive(false);
        ForgottenCanvas.SetActive(false);

        // Enable login
        LoginCanvas.SetActive(true);
    }
    #endregion

    // --------------------------------------------------------------------------------------

    #region Sign up

    [Header("Sign up screen")]
    public GameObject SignUpCanvas;
    public GameObject TOS_Panel;

    public void SignUp(){
        // Send to Sign up screen

        // Disable login screen
        LoginCanvas.SetActive(false);
        

        // Enable sign up screen    
        SignUpCanvas.SetActive(true);
        
    }

    public void EnableTOS(){
        TOS_Panel.SetActive(true);
    }

    public void DisableTOS(){
        TOS_Panel.SetActive(false);
    }
    #endregion

    // --------------------------------------------------------------------------------------

    #region Forgotten password

    [Header("Forgotten pass screen")]
    public GameObject ForgottenCanvas;

    public void ForgotPass(){
        // Disable the login screen
        LoginCanvas.SetActive(false);
        // Enable the forgotten pass
        ForgottenCanvas.SetActive(true);
    }
    #endregion

    // --------------------------------------------------------------------------------------

    #region 

    #endregion
}