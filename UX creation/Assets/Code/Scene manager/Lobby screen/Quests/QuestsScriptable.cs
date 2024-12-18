using UnityEngine;

[CreateAssetMenu (menuName = "Quests/QuestPrefab")]
public class QuestsScriptable : ScriptableObject
{
    public Quests[] quests;
}

[System.Serializable]
public class Quests
{
    public Sprite Icon;
    public string Header;
    public string Description;
    public string ChallengeAmount;
    public float XPAmount;
}