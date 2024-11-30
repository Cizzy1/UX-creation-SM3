// TUTORIAL USED -> https://youtu.be/aUi9aijvpgs?si=p01KwYbaeCKoyzXC

using System.Collections.Generic;
using UnityEngine;

// Something about making finding objects with IDataPersistence easier
using System.Linq;

public class DataPersistenceManager : MonoBehaviour
{
    [Header("File storage config")]
    [SerializeField] private string fileName;

    private GameData gameData;
    public List<IDataPersistence> dataPersistencesOBJs;
    private FileDataHandler dataHandler;

    public static DataPersistenceManager instance {get; private set;}

    void Awake(){
        // used to make sure that there is only one within the scene
        if(instance != null){
            Debug.LogError("Found another data persistence manager");
        }

        instance = this;
    }

    void Start(){
        // Set up the file
        this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName);
        
        // Find all objects with the IDataPersistence interface
        this.dataPersistencesOBJs = FindAllDataPersistence();

        // Loads the game data on startup
        LoadGame();
    }

    public void NewGame(){
        this.gameData = new GameData();
    }

    public void LoadGame(){
        /// <summary>
        /// This will open any saved data that the player has
        /// 
        /// TODO
        /// - Load any of the saved data using DataHandler.cs
        /// - Send all of the required data to the required places
        /// - If there is no data to be pulled. Call NewGame();
        /// </summary>
        
        // Load all of the data from the .json file
        this.gameData = dataHandler.Load();
        
        // Checking if there is any saved data
        if(this.gameData == null){
            // There is no saved data so this will set everything to the
            // default values
            Debug.LogWarning("There is no game data to be found!");
            NewGame();
        }

        foreach(IDataPersistence dataPersistencesObjects in dataPersistencesOBJs)
        {
            // For each object within what is found to have the IDataPersistence
            // interface they are all updated with the gameData
            dataPersistencesObjects.LoadData(gameData);
        }
    }

    public void SaveGame(){
        /// <summary>
        /// This will open any saved data that the player has
        /// 
        /// TODO
        /// - Pass data to other scripts to update it
        /// - Then save to a file using the DataHandler.cs
        /// </summary>

        // same as loading the data. What ever has the IDataPersistence interface
        // will overwrite data stored within GameData.cs
        foreach (IDataPersistence dataPersistenceObjects in dataPersistencesOBJs)
        {
            dataPersistenceObjects.SaveData(ref gameData);
        }

        // Save any of the data within the scene
        dataHandler.Save(gameData);
    }

    public void OnApplicationQuit(){
        // Save the game when the application is closed
        // well just before
        SaveGame();
    }

    // A slight change that I will be making for this is
    // changing it from a private function to a public function
    // This will be needed as this will need to be called from
    // outside and by other scripts. This is as this will not
    // find all game objects as many will be set to inactive
    public List<IDataPersistence> FindAllDataPersistence(){
        // This will find every single game object that utilises the IDataPersistence interface
        IEnumerable<IDataPersistence> dataPersistencesOBJs = FindObjectsOfType<MonoBehaviour>().OfType<IDataPersistence>();

        return new List<IDataPersistence>(dataPersistencesOBJs);
    }
}
