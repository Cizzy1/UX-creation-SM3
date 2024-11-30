// TUTORIAL USED -> https://youtu.be/aUi9aijvpgs?si=p01KwYbaeCKoyzXC

[System.Serializable]
public class GameData 
{
    // Testing
    public int PlayerScore;

    // Login details
    public string PlayerUsername;
    public string PlayerPassword;
    

    // Other game things will be saved here


    // On the start this will automatically set everything to a default value
    public GameData(){
        PlayerScore = 0;
    }
}
