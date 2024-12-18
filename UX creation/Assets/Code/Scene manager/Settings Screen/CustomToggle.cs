using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CustomToggle : MonoBehaviour
{
    [Header("Icons")]
    public Image[] BottomIcons;

    [Header("Text")]
    public TMP_Text OptionText;
    // This index based so they need to be entered correctly
    public string[] PossibleOptions;
    
    [Header("Current option")]
    public int CurrentOption;
    [Tooltip("Take the amount of options")]
    public int AmountOfOptions;

    void Start(){
        CurrentOption = 0;
    }

    public void ToggleRight(){
        ClearStatus();

        CurrentOption ++;

        if(CurrentOption == AmountOfOptions){
            CurrentOption = 0;
        }

        // Change the text accordingly
        OptionText.text = PossibleOptions[CurrentOption];

        // Change the bottom icon to active
        SetIconActive(CurrentOption);

        // This will reset the options back to the start
    }

    public void ToggleLeft(){
        ClearStatus();

        CurrentOption --;

        if(CurrentOption == -1){
            CurrentOption = AmountOfOptions-1;
        }

        // Change the text accordingly
        OptionText.text = PossibleOptions[CurrentOption];

        // Change the bottom icon to active
        SetIconActive(CurrentOption);

        // This will reset the options back to the start
    }

    void ClearStatus(){
        for (int i = 0; i < BottomIcons.Length; i++)
        {
            // This sets every icon to a white transparent.
            // Tacky but quickest way to deselect the previous ¯\_(ツ)_/¯
            BottomIcons[i].color = new Color(BottomIcons[i].color.r, 
                                            BottomIcons[i].color.g, 
                                            BottomIcons[i].color.b, .5f);
        }
    }

    void SetIconActive(int index){
        // This sets the icon to a opaque
        BottomIcons[index].color = new Color(BottomIcons[index].color.r, 
                                            BottomIcons[index].color.g, 
                                            BottomIcons[index].color.b, 1f);
    }
}
