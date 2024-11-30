using TMPro;
using UnityEngine;

public class LoginChecker : MonoBehaviour
{
    public PassManager passManager;

    public TMP_InputField Username;
    public TMP_InputField Password;

    public bool UsernameCorrect = false;
    public bool PasswordCorrect = false;

    [Header("Temp and login to loading")]
    public GameObject LoginCanvas;
    public GameObject LoadingCanvas;
    
    public void CheckFields(){
        // Check if the text in the field matches that of the passManager

        if(Username.text == ""){
            Debug.Log("No username entered");
            
        }else if(Username.text == passManager.Nickname){
            UsernameCorrect = true;
        }

        if(Password.text == ""){
            Debug.Log("No username entered");
        }else if(Password.text == passManager.Password){
            PasswordCorrect = true;
        }

        if(UsernameCorrect && PasswordCorrect){
            // Start the loading screen as this means both the username & pass
            // are correct. This will change and is only a temp system for
            // 20/11/24

            Debug.Log("logged into " + passManager.Nickname);

            // Temp for now I will load the loading screen from here as well
            LoginCanvas.GetComponent<SimpleAnimations>().CloseAnimation();
            //LoginCanvas.SetActive(false);
            // Another temp of loading the screen from this script.
            LoadingCanvas.SetActive(true);
        }
    }
}
