using System.Collections.Generic;
using System.Reflection;
using Unity.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
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
    
    [Header("Screens")]
    public List<GameObject> Canvas;

    [Header("Buttons")]
    public List<Image> allBts;

    [Header("Sprites")]
    public Sprite HighlightedImage;
    public Sprite NormalImage;

    // Script references
    BottomButtonsAnimations bottomButtonsAnimations;

    public void Start(){
        ClearStatus();
        CheckIndex(0);
    }

    // Remove  this from a update as this will also just keep opening the screen
    // throwing players off as they wont be able to interact.
    public void CheckIndex(int Index){
        // Off the start the Index will always be 0
        switch (Index)
        {
            case 0:
                //Debug.Log("Selected play");
                Play();
                break;

            case 1:
                //Debug.Log("Selected Quests");
                Quests();
                break;

            case 2:
                //Debug.Log("Selected Rhu-pass");
                RhuPass();
                break;

            case 3:
                //Debug.Log("Selected Locker");
                Locker();
                break;

            case 4:
                //Debug.Log("Selected Shop");
                Shop();
                break;

            case 5:
                //Debug.Log("Selected Career");
                Career();
                break;

            default:
                Debug.Log("nothing");
                break;
        }
    }

    // On a button click i change the index int (done through button event)
    // in the switch this correlates to a function (switch will call this)
    // this function needs to change the sprite to active
    // and also open said screen.

    public void Play(){
        // Clear every button from being highlighted
        ClearStatus();

        // I know the index of the play button is 0
        // This can be done throughout the rest of this
        allBts[0].sprite = HighlightedImage;

        // This will stop the nudge animation playing on this button
        allBts[0].GetComponent<BottomButtonsAnimations>().IsActive = true;
        // Now need to activate the animation for the button being active
        allBts[0].GetComponent<BottomButtonsAnimations>().ActiveAnim();


        // And I know the index of the canvas is 0
        Canvas[0].SetActive(true);
    }

    public void Quests(){
        ClearStatus();

        allBts[1].sprite = HighlightedImage;

        allBts[1].GetComponent<BottomButtonsAnimations>().IsActive = true;
        allBts[1].GetComponent<BottomButtonsAnimations>().ActiveAnim();

        Canvas[1].SetActive(true);
    }

    public void RhuPass(){
        ClearStatus();

        allBts[2].sprite = HighlightedImage;

        allBts[2].GetComponent<BottomButtonsAnimations>().IsActive = true;
        allBts[2].GetComponent<BottomButtonsAnimations>().ActiveAnim();

        Canvas[2].SetActive(true);
    }

    public void Locker(){
        ClearStatus();

        allBts[3].sprite = HighlightedImage;

        allBts[3].GetComponent<BottomButtonsAnimations>().IsActive = true;
        allBts[3].GetComponent<BottomButtonsAnimations>().ActiveAnim();

        Canvas[3].SetActive(true);
    }

    public void Shop(){
        ClearStatus();

        allBts[4].sprite = HighlightedImage;

        allBts[4].GetComponent<BottomButtonsAnimations>().IsActive = true;
        allBts[4].GetComponent<BottomButtonsAnimations>().ActiveAnim();

        Canvas[4].SetActive(true);
    }

    public void Career(){
        ClearStatus();

        allBts[5].sprite = HighlightedImage;

        allBts[5].GetComponent<BottomButtonsAnimations>().IsActive = true;
        allBts[5].GetComponent<BottomButtonsAnimations>().ActiveAnim();

        Canvas[5].SetActive(true);
    }

    // This sets all of the buttons to none clicked
    void ClearStatus(){
        foreach (var Image in allBts)
        {
            Image.sprite = NormalImage;
            Image.GetComponent<BottomButtonsAnimations>().IsActive = false;
            Image.GetComponent<BottomButtonsAnimations>().DefaultPos();
        }

        foreach (var canvas in Canvas)
        {
            canvas.SetActive(false);
        }
    }
}