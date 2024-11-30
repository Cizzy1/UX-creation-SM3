using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Autofill : MonoBehaviour
{
    LoginChecker loginChecker;
    PassManager passManager;
    public int TrueOrFalse;

    // Input fields. These will be autofilled
    public TMP_InputField UsernameField;
    public TMP_InputField PasswordField;
    public Toggle toggle;

    void Start(){
        // This grabs the int from the 
        loginChecker = GameObject.Find("Credentials Checker").GetComponent<LoginChecker>();
        passManager = GameObject.Find("Credentials Checker").GetComponent<PassManager>();

        TrueOrFalse = loginChecker.RememberInt;

        if(TrueOrFalse == 1){
            Debug.Log("Filled out the credentials");
            
            // Autofill
            UsernameField.text = passManager.Nickname;
            PasswordField.text = passManager.Password;
            toggle.isOn = true;

        }else{
            Debug.Log("You haven't saved credientials and will have to fill them out again");
            toggle.isOn = false;
        }
    }
}