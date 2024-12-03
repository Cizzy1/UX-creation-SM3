// TUTORIAL USED -> https://youtu.be/aUi9aijvpgs?si=p01KwYbaeCKoyzXC

using UnityEngine;

[System.Serializable]
public class GameData 
{
    // Testing
    public int PlayerScore;

    // Login details
    [Header ("Player details")]
    public string PlayerUsername;
    public string PlayerPassword;
    // 1 = true     0 = false
    public int RememberCredentials;

    // User account specifics
    public int PlayerLevel;
    

    // Other game things will be saved here


    // On the start this will automatically set everything to a default value
    // This is if there is no found existing game data
    public GameData(){
        RememberCredentials = 0;
        PlayerLevel = 1;
    }
}