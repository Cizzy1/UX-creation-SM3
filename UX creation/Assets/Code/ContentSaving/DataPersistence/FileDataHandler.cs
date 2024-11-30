// TUTORIAL USED -> https://youtu.be/aUi9aijvpgs?si=p01KwYbaeCKoyzXC

using UnityEngine;
using System;
using System.IO;

public class FileDataHandler
{
    // Where the file will be placed
    private string dataDirPath = "";
    // The name of the file
    private string dataFileName = "";

    // Encryption for the file

    // Setting the variables
    public FileDataHandler(string dataDirPath, string dataFileName){
        this.dataDirPath = dataDirPath;
        this.dataFileName = dataFileName;
    }

    // return data to Gamedata object
    public GameData Load()
    {
        // Path.Combine() "accounts for different OS's having different path separators". 
        string FullPath = Path.Combine(dataDirPath, dataFileName);

        GameData loadedData = null;

        // Checking if the file exists
        if(File.Exists(FullPath))
        {
            try
            {
                // This is where the file contents will be read
                string dataToLoad = "";

                // Opens the file
                using (FileStream stream = new FileStream(FullPath, FileMode.Open))
                {
                    // Reads the file
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        // Sets the data to load to contents of this file
                        dataToLoad = reader.ReadToEnd();
                    }
                }

                // Now all of this data needs to be deserialised from the .Json
                // This is as the contents of the .Json mean nothing to Unity
                // meaning that all the saved data becomes useless after being stored
                // then pulled to use.
                loadedData = JsonUtility.FromJson<GameData>(dataToLoad);
            }
            catch (Exception e)
            {
                Debug.LogError("Error occured when tryting to load data from -> " + FullPath + "\n" + e);
            }
        }

        return loadedData;
    }

    // Take in GameData object
    public void Save(GameData data){
        // Path.Combine() "accounts for different OS's having different path separators". 
        string FullPath = Path.Combine(dataDirPath, dataFileName);

        // This will check if this path even exists.
        // If it cannot find a path it will throw what is inside catch
        try
        {
            // This will create a directory for the file if it doesnt exist yet
            Directory.CreateDirectory(Path.GetDirectoryName(FullPath));

            // Turning the C# game data object into a .json
            string dataToStore = JsonUtility.ToJson(data, true);

            // Write the data to the file
            using (FileStream stream = new FileStream(FullPath, FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write(dataToStore);
                }
            }
        }
        catch (Exception e)
        {
            Debug.LogError("Error occured when saving at -> " + FullPath + "\n" + e);
        }
    }
}