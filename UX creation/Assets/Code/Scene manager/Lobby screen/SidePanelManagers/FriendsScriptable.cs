using UnityEngine;

[CreateAssetMenu (menuName = "Friends/FriendsObjects")]
public class FriendsScriptable : ScriptableObject
{
    public Friends[] friends;
}

[System.Serializable]
public class Friends
{
    public Sprite ActivityStatus;
    public string Username;
    public string Status;
}
