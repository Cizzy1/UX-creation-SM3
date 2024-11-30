// TUTORIAL USED -> https://youtu.be/aUi9aijvpgs?si=p01KwYbaeCKoyzXC

public interface IDataPersistence
{
    // I qoute "just going to be used to describe the methods
    // that the implementing scripts needs to have". I do not
    // know how or what this script does. I may come back to
    // this once later into the tut

    // Update. IDataPersistence will have to be used next to 
    // MonoBehaviour on scripts that I want to store data from.

    // "only cares about reading data"
    void LoadData(GameData data);

    void SaveData(ref GameData data);
}
