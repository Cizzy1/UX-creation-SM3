using UnityEngine;

[CreateAssetMenu (menuName = "Rhu Pass/Items")]
public class RhuPassItems : ScriptableObject
{
    public Items[] items;
}

[System.Serializable]
public class Items
{
    // This needs to be a prefab as the scailing will
    // be incorrect otherwise and that
    public GameObject ItemIcon;
    public float TierNumber;
    public string ItemName;
    public string Description;

    public GameObject ItemToPresent;
}

// EVERY ITEM MADE WITHIN THIS HAS TO BE IN THE CORRECT ORDER
// IN THE SCRIPTABLE OBJECT TO MAKE THE SYSTEM WORK;