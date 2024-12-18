using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestsManager : MonoBehaviour
{    
    List<int> questsInUse = new List<int>();
    
    // Using Vecticle layout groups
    // Link to reference here -> https://youtu.be/zbUVWnq9j20?si=Xwezm6tk9XkfUJt1
    public GameObject ContentGO;
    // Base prefab all of the elements will be switched out according to scriptable objects
    public GameObject QuestsTemplate;
    // Reference to the Scriptable so that I can grab the variables from the class
    public QuestsScriptable questsScriptables;
    // How many quests do you want. This cannot be higher than the amount of created quests as
    // it will throw a array error as the idex is out of bounds. Obviously as you cant generate
    // more quests that what has been made.
    public int AmountOfQuests;
    // Stops from trying to run again if the screen is closed then reopened
    bool hasGenerated;

    void Start()
    {
        // This is so that you can re open without throwing errors or in the old version
        // re generating the quests by simply clicking back on the tab.
        if(!hasGenerated){
            // Cant run again now after this first time around
            hasGenerated = true;

            // Loops through the set amount of quests
            for (int i = 0; i < AmountOfQuests; i++)
            {
                // This randomInt will be used for the index of the items to switch out with
                // This randomInt is what picks which scriptable object to choose from
                int randomInt = Random.Range(0, questsScriptables.quests.Length);

                // if the index is already in use (aka quest already exists) do not do anything
                // and minus one off of the loop
                if(questsInUse.Contains(randomInt))
                {
                    i--;
                }
                // Where as if the index is not used. Generate a quest using the randomInt
                else if(!questsInUse.Contains(randomInt))
                {
                    GenerateRandomQuests(randomInt);
                    // Then add this index to the List so that it cant spawn it again
                    questsInUse.Add(randomInt);
                }
            }
        }
    }

    void GenerateRandomQuests(int index)
    {
        // By instantiating a the base prefab everything can be changed from here
        // This also allows the Verticle layout groups to work. (this just automatically spaces 
        // out the quests without extra code)
        GameObject QuestObject = Instantiate(QuestsTemplate, ContentGO.transform);
        
        // Messy but it works and essentially just finds all of the child game objects by name 
        // and then gets the component then changes a specific part of the component for something
        // that is specified on the index. Aka the index gets the scriptable object and then applies whatever
        // there is on it to the current base template spawned in above
        QuestObject.transform.Find("Icon").GetComponent<Image>().sprite = questsScriptables.quests[index].Icon;
        if(questsScriptables.quests[index].Icon.name == "HouseIcon" || questsScriptables.quests[index].Icon.name == "SkullIcon"){
            QuestObject.transform.Find("Icon").GetComponent<Image>().SetNativeSize();
        }
        QuestObject.transform.Find("Header").GetComponent<TMP_Text>().text = questsScriptables.quests[index].Header;
        QuestObject.transform.Find("Time Left").GetComponent<TMP_Text>().text = Random.Range(1,6) + "d " + Random.Range(1,24) + "h";
        QuestObject.transform.Find("Description").GetComponent<TMP_Text>().text = questsScriptables.quests[index].Description;
        QuestObject.transform.Find("Accomplishment").GetComponent<TMP_Text>().text = questsScriptables.quests[index].ChallengeAmount;
        QuestObject.transform.Find("RewardAmount").GetComponent<TMP_Text>().text = questsScriptables.quests[index].XPAmount + "k";
    }
}