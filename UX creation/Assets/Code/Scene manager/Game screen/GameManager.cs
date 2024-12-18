using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        ClearStatus();
        // This will set the first hot bar item to be active
        CurrentBarSelection(0);
    }

    [Header("Open Quests")]
    public GameObject QuestScreen;
    public bool isOpen;

    void Update()
    {
        if(!isOpen && Input.GetKeyDown(KeyCode.Q)){
            isOpen = true;
            // This will open the quests.
            QuestScreen.SetActive(true);
        }
        else if(Input.GetKeyDown(KeyCode.Q)){
            isOpen = false;
            QuestScreen.SetActive(false);
        }
        

        // I am slowly giving in at this point
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            CurrentBarSelection(0);
        }

        if(Input.GetKeyDown(KeyCode.Alpha2)){
            CurrentBarSelection(1);
        }

        if(Input.GetKeyDown(KeyCode.Alpha3)){
            CurrentBarSelection(2);
        }

        if(Input.GetKeyDown(KeyCode.Alpha4)){
            CurrentBarSelection(3);
        }
    }
    public void CloseQuests(){
        QuestScreen.SetActive(false);
    }


    // Map open

    public GameObject MapScreen;
    public void OpenMap(){
        MapScreen.SetActive(true);
    }
    public void CloseMap(){
        MapScreen.SetActive(false);
    }


    // Inventory system
    [Header("Inventory")]
    public GameObject[] HotbarSlots;
    public ItemSlots itemSlots;
    public Sprite HotbarActive, HotbarNonActive;
    public TMP_Text ItemName, ItemMagSize;

    void CurrentBarSelection(int index){
        ClearStatus();
        // Item slot change to be selected
        HotbarSlots[index].transform.Find("BG").GetComponent<Image>().sprite = HotbarActive;

        // This then needs to change some text.
        // This can be easily made with scriptable objects but I do not have the time as of
        // right now to waste the extra time needed so it will be hard coded

        ItemName.text = itemSlots.items[index].ItemName;
        ItemMagSize.text = itemSlots.items[index].BulletsToMags;
    }
    
    void ClearStatus(){
        // Loop through all of the 
        for (int i = 0; i < HotbarSlots.Length; i++)
        {
            // This is the easiest way for my current non functioning brain to deactivate the
            // slots without having to keep track
            HotbarSlots[i].transform.Find("BG").GetComponent<Image>().sprite = HotbarNonActive;
        }
    }
}