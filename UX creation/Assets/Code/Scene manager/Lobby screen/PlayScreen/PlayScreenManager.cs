using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayScreenManager : MonoBehaviour, IDataPersistence
{

    void Start()
    {
    }

    // This is a temp feature
    float EXP = .25f;
    void Update(){
        if(Input.GetKeyDown(KeyCode.E)){
            BarFill();
        }
    }

    [Header("Player Name")]
    public TMP_Text PlayerNameBG;
    public TMP_Text PlayerNameMain;

    [Header("Player Level")]
    public TMP_Text PlayerLevelText;
    public Image PlayerLevelFillBar;

    void BarFill(){
        PlayerLevelFillBar.fillAmount += EXP;

        if(PlayerLevelFillBar.fillAmount == 1){
            // from a game view this would +1 lvl to the player level and save
            // In this though I dont care about the level text as this is temporary.

            // This is just to reset it
            PlayerLevelFillBar.fillAmount = 0;
        }
    }

    public void LoadData(GameData data)
    {
        // This will set the player name seen in the bottom left of the screen.
        this.PlayerNameBG.text = data.PlayerUsername;
        this.PlayerNameMain.text = data.PlayerUsername;

        // In the game scene there will be a level up/kill key. Every 5 kills will
        // account to 1 level. So along with moving the level bar the players level
        // will also change once returning to the lobby. This is only a demonstration
        // and in a real use case I would not do this.
        this.PlayerLevelText.text = "Level " + data.PlayerLevel.ToString();
    }

    public void SaveData(ref GameData data)
    {
    }


    // Select Mode
    [Header("Mode Popup")]
    public GameObject GameModeSelectButton;
    public GameObject GameModePopUp;

    [Tooltip("These have to be in the same order index as whats in the script. So solos is index = 0")]
    public Sprite[] GameModeSprites;

    int CurrentIndex;

    public void OpenGameMode(){
        GameModePopUp.SetActive(true);
    }

    public void SelectMode(int index){
        // Change gamemode picture
        GameModeSelectButton.GetComponent<Image>().sprite = GameModeSprites[index];
    }

    public void ClosePopup(){
        GameModePopUp.GetComponent<CloseGO>().CloseOBJ();
    }


    public void PlayGame(){
        SceneManager.LoadScene("MainScreen");
    }
}
