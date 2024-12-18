using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CareerManager : MonoBehaviour
{
    public GameObject[] DifferentTabs;
    public GameObject[] Buttons;

    public Sprite NormalBTN;
    public Sprite SelectedBTN;

    void Start(){
        ChangeTab(0);
    }

    public void ChangeTab(int index){

        for (int i = 0; i < DifferentTabs.Length; i++)
        {
            DifferentTabs[i].SetActive(false);
            Buttons[i].GetComponent<Button>().interactable = true;
            Buttons[index].GetComponent<Image>().sprite = NormalBTN;    
        }

        Buttons[index].GetComponent<Button>().interactable = false;
        Buttons[index].GetComponent<Image>().sprite = SelectedBTN;
        DifferentTabs[index].SetActive(true);
    }

    [Header("Drop down")]
    public TMP_Text dropDownText;

    public void ChangeDropDown(){
        if(dropDownText.text == "SOLOS"){

        }
        if(dropDownText.text == "DUOS"){
            
        }
        if(dropDownText.text == "TRIOS"){
            
        }
        if(dropDownText.text == "SQUADS"){
            
        }
    }

    public void ChangeVisible(GameObject obj){

    }
}
