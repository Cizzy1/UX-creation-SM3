using UnityEngine;
using UnityEngine.UI;
public class BottomButtonsMan : MonoBehaviour
{
    // In this script I will control the buttons across the bottom of the screen.
    // This will be much like the HardCodedLogin.cs script and will change through
    // the different panel dependant on the buttons across the bottom of the screen.
    
    /// <summary>
    /// What do I want this script to do?
    /// 
    /// - Need a reference to the other screen canvas's
    /// - Need references to all of the buttons
    /// 
    /// Perchance a switch statement? Buttons change a int. Update sees this
    /// changes to the correct screen and also within the correct function
    /// sets the sprite to be active??????
    /// </summary>
    public GameObject Canvas1, Canvas2;

    // This needs to be set to the default of PlayBTN
    public GameObject CurrentButton;
    public GameObject LastButton;

    public Sprite HighlightedImage;
    public Sprite NormalImage;

    void Start(){
        Play();
        LastButton = CurrentButton;
    }

    // Remove  this from a update as this will also just keep opening the screen
    // throwing players off as they wont be able to interact.
    public void CheckIndex(int Index){
        // Off the start the Index will always be 0
        switch (Index)
        {
            case 0:
                Debug.Log("Selected play");
                // call function that changes the screen and
                // also keeps the button active as well. Even
                // off click

                break;

            case 1:
                Debug.Log("Selected Quests");
                Quests();
                break;

            case 2:
                Debug.Log("Selected Rhu-pass");
                break;

            default:
                Debug.Log("nothing");
                break;
        }
    }

    // This next section will only be commented once

    public void SelectedBTN(GameObject thisGO){
        LastButton = CurrentButton;

        // Can drag and drop the GO into this (itself)
        // This will have to be called as well on the button

        // This will set the current button to the currently
        // clicked button. This can then be used later below
        CurrentButton = thisGO;

        // I guess now is to also to keep track of the previously
        // pressed button
    }

    public void Play(){
        LastButton.GetComponent<Image>().sprite = NormalImage;
        // Set the button to active
        // Need a reference to the button. I dont think its possible to
        // grab a button through a press
        CurrentButton.GetComponent<Image>().sprite = HighlightedImage;

    }

    public void Quests(){
        LastButton.GetComponent<Image>().sprite = NormalImage;
        CurrentButton.GetComponent<Image>().sprite = HighlightedImage;
    }

}
