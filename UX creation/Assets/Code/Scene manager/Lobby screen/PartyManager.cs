using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PartyManager : MonoBehaviour, IDataPersistence
{
    [Header("Player Name")]
    public TMP_Text PlayerNameText;

    [Header("Player Status")]
    public TMP_Text ReadyStatusText;

    public void ReadyStatus(){
        // This is a button event and will just simply switch between the player being ready
        // and not being ready. This will change the ready status on the player and also
        // change the button text in the bottom right.
    }

    [Header("Party Members")]
    public GameObject PlayerSlot1;
    public GameObject PlayerSlot2;
    public GameObject PlayerSlot3;

    public void LoadData(GameData data)
    {
        PlayerNameText.text = data.PlayerUsername;
    }

    public void SaveData(ref GameData data)
    {
    }
}