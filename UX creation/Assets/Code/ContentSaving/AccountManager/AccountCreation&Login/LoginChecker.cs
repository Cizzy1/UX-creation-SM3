using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoginChecker : MonoBehaviour, IDataPersistence
{
    public PassManager passManager;
    DataPersistenceManager dataPersistenceManager;
    public Toggle RememberMeToggle;
    public int RememberInt;

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
            Debug.Log("logged into " + passManager.Nickname);

            if(RememberMeToggle.isOn){
                Debug.Log("Your credentials have been saved");
                // As I cannot save toggle in the .json I will use a int as
                // a way to save it.
                // Setting the int to 1 = true;
                RememberInt = 1;

            } else if(RememberMeToggle.isOn == false){
                Debug.Log("Your credentials have not saved");

                // Setting the int to 0 = false;
                RememberInt = 0;
            }
            // Save the data from the remember me toggle
            dataPersistenceManager = GameObject.Find("DataPersistenceManager")
                                    .GetComponent<DataPersistenceManager>();
            dataPersistenceManager.SaveGame();

            // Temp for now I will load the loading screen from here as well
            LoginCanvas.GetComponent<SimpleAnimations>().CloseAnimation();
            //LoginCanvas.SetActive(false);
            // Another temp of loading the screen from this script.
            LoadingCanvas.SetActive(true);

        }
    }

    public void LoadData(GameData data){
        // This will set the score to whatever is saved in the json file
        this.RememberInt = data.RememberCredentials;
    }

    public void SaveData(ref GameData data){
        // This will need to overwrite anything within GameData
        // This is literally only a reverse of how you load
        data.RememberCredentials = this.RememberInt;
    }
}