using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// If the Event system has a certain tag
/// Search for 
/// </summary>

public class SnapPlayerInfo : MonoBehaviour
{
    [Header("Popup")]
    public GameObject PopupParent;
    public GameObject BigButton;

    public void MovePopup(GameObject GO){
        BigButton.SetActive(true);
        PopupParent.SetActive(true);
        PopupParent.transform.position = Input.mousePosition;

        PopupParent.transform.Find("Name").GetComponent<TMP_Text>().text = GO.GetComponent<TMP_Text>().text;
    }

    [Header("Characters & player tag")]
    public GameObject[] Characters;
    public GameObject GO;

    void Update(){
        if(Input.GetMouseButtonDown(0) && EventSystem.current.currentSelectedGameObject.tag == "Player"){
            GO = EventSystem.current.currentSelectedGameObject;
        }
    }
    public void RemovePlayer(){
        Debug.Log("Remove " + GO.name);

        GO.transform.parent.gameObject.SetActive(false);

        if(GO.transform.parent.name == "PlayerContainer_2"){
            // Disable objects
            Characters[0].SetActive(false);
        }

        if(GO.transform.parent.name == "PlayerContainer_3"){
            Characters[1].SetActive(false);
        }

        if(GO.transform.parent.name == "PlayerContainer_4"){
            Characters[2].SetActive(false);
        }
        
    }

    public void BIGBUTTTON(){
        BigButton.SetActive(false);
        PopupParent.SetActive(false);
    }
}
