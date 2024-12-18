using UnityEngine;

[CreateAssetMenu (menuName = "Hotbar/Items")]
public class ItemSlots : ScriptableObject
{
    public Hotbar[] items;
}

[System.Serializable]
public class Hotbar
{
    // This GO will not be used
    // It is a in game item and not
    // relevent to the UI creation
    public GameObject ItemInGame;
    // This doesnt matter in this case
    // Just another representation of 
    // how items can be built up
    public Sprite Icon;
    public string ItemName;
    // Not needed again but this is
    // a part of the UI I dont understand
    public float OverallAmmo;
    // How many bullets there is and bullets
    // left (i think)
    public string BulletsToMags;

}
