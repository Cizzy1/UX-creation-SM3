using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LeftPanelManager : MonoBehaviour
{
    // This script is going to be a near carbon copy of the QuestsManager.cs script so
    // I will not be commenting this script as it will be the same
    List<int> friendsInUse = new List<int>();

    public GameObject ContentGO;
    public GameObject BaseTemplate;
    public FriendsScriptable friendsScriptable;
    int AmountOfFriends;
    int OnlineFriends;
    bool hasGenerated;

    [Header("LeftPanel")]
    public TMP_Text HeaderBG;
    public TMP_Text HeaderText;

    [Header("Button text")]
    public TMP_Text OnlineTextBG;
    public TMP_Text OnlineText;

    void Start(){
        AmountOfFriends = Random.Range(7, 20);

        if(!hasGenerated){
            hasGenerated = true;

            for (int i = 0; i < AmountOfFriends; i++)
            {
                int randomInt = Random.Range(0, friendsScriptable.friends.Length);

                if(friendsInUse.Contains(randomInt))
                {
                    i--;
                }
                else if(!friendsInUse.Contains(randomInt))
                {
                    GenerateRandomQuests(randomInt);
                    friendsInUse.Add(randomInt);
                }
            }
        }

        // Setting how many friends are online and overall
        HeaderBG.text = "Friends (" + OnlineFriends + "/" + AmountOfFriends + ")";
        HeaderText.text = "Friends (" + OnlineFriends + "/" + AmountOfFriends + ")"; 

        OnlineTextBG.text = OnlineFriends.ToString();
        OnlineText.text = OnlineFriends.ToString();
    }

    void GenerateRandomQuests(int index)
    {
        GameObject FriendObject = Instantiate(BaseTemplate, ContentGO.transform);

        FriendObject.transform.Find("BG").GetComponent<Image>().sprite = friendsScriptable.friends[index].ActivityStatus;
        FriendObject.transform.Find("BG").GetComponent<Image>().SetNativeSize();

        // If they are any of these status's set them to be online players
        if(friendsScriptable.friends[index].ActivityStatus.name == "Online" || 
            friendsScriptable.friends[index].ActivityStatus.name == "Idle" ||
            friendsScriptable.friends[index].ActivityStatus.name == "Ingame")
        {
            // Increase online players by +1
            OnlineFriends ++;
        }

        FriendObject.transform.Find("Name").GetComponent<TMP_Text>().text = friendsScriptable.friends[index].Username;
        FriendObject.transform.Find("Status").GetComponent<TMP_Text>().text = friendsScriptable.friends[index].Status;
    }

    // Creating a friend
}