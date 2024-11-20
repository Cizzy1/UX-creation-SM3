using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AccountCreation : MonoBehaviour
{
    // Requirements
    public PassManager passManager;
    public TMP_InputField SignUpNickname;
    public TMP_InputField SignUpPassword;
    public TMP_InputField[] inputs;
    bool inputsEntered;
    public Toggle TOStoggle;
    bool AgreedToTOS = false;

    public void SignUP(){
        inputsEntered = true;
        foreach (var Input in inputs)
        {
            if(Input.text == ""){
                Debug.LogWarning("Not every field is complete!!!");
                inputsEntered = false;
                break;
            }
        }

        if(TOStoggle.isOn){
            Debug.Log("User has agreed");
            AgreedToTOS = true;
        }else{
            Debug.Log("User hasn't agreed to the TOS");
            AgreedToTOS = false;
        }

        if(AgreedToTOS && inputsEntered){
            AddNickAndPass();
        }
    }

    public HardCodedLogin hardCodedLogin;
    public void AddNickAndPass(){
        passManager.Nickname = SignUpNickname.text;
        passManager.Password = SignUpPassword.text;

        hardCodedLogin.ReturnToLogin();
    }
}
