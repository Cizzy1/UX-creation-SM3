using UnityEngine;

public class PassManager : MonoBehaviour, IDataPersistence
{
    public string Nickname;
    public string Password;

    DataPersistenceManager dataPersistenceManager;

    void Start(){
        dataPersistenceManager = GameObject.Find("DataPersistenceManager").GetComponent<DataPersistenceManager>();
    }

    void Update(){
        if (Nickname != "" && Password != "")
        {
            dataPersistenceManager.SaveGame();
        }
    }

    public void LoadData(GameData data){
        // Username
        this.Nickname = data.PlayerUsername;

        // Password
        this.Password = data.PlayerPassword;
    }

    public void SaveData(ref GameData data){
        // Username
        data.PlayerUsername = this.Nickname;

        // Password
        data.PlayerPassword = this.Password;
    }
}