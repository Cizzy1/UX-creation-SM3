using TMPro;
using UnityEngine;
/// <summary>
/// The use of this script is just a quick test point for me.
/// This is as it is hard and too much work right off the start
/// to get this working with the sign up and login. So I am using
/// this script to make sure that I can store things correctly
/// So that I am not wasting my time ripping my hair out over something
/// I can't see not being saved. Plus this script acts as a really good
/// reference point for me on requirements
/// </summary>


// IDataPersistence is referenced
public class ScoreSavingTest : MonoBehaviour, IDataPersistence
{
    public int Score;
    public TMP_Text ScoreText;

    // In start this is my own code to add disabled objects
    // to the DataPersistenceManager as the video only applies
    // to every gameobject that stores data is already active
    // within the scene
    void Start(){
        //AddToDataPersistence();
        ScoreText.text = "Score amount: " + Score;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            Score++;
            ScoreText.text = "Score amount: " + Score;
        }
    }

    // This is called so that any contents within this script are saved
    // AKA the score is what im trying to save.
    public void LoadData(GameData data){
        // This will set the score to whatever is saved in the json file
        this.Score = data.PlayerScore;

        transform.root.gameObject.SetActive(false);
    }

    public void SaveData(ref GameData data){
        // This will need to overwrite anything within GameData
        // This is literally only a reverse of how you load
        data.PlayerScore = this.Score;
    }



    // For cases where this script will be enabled at a later time
    // This obj will need to be added to the DataPersistenceManager.cs
    // once it is enabled so Start(). This is required to save data.

    // A reference to the manager will be needed to call variables
    public DataPersistenceManager dataPersistenceManager;

    /* void AddToDataPersistence(){
        GameObject Manager = GameObject.Find("DataPersistenceManager");
        dataPersistenceManager = Manager.GetComponent<DataPersistenceManager>();
        dataPersistenceManager.dataPersistencesOBJs.Add(this);
    } */
}