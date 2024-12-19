using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LockerManager : MonoBehaviour
{
    [Header("Player in locker")]
    public GameObject PlayerTransform;
    public float RotationSpeed;

    void Update()
    {
        // While the mouse is clicked down and the mouse is within the region
        // Rotate the character by a set speed
        if(Input.GetMouseButton(0) && EventSystem.current.currentSelectedGameObject.name == "RenderTexture"){
            float h = RotationSpeed * Input.GetAxis("Mouse X");
            PlayerTransform.transform.Rotate(0, -h, 0);
        }
    }

    [Header("Original screen buttons")]
    public Image[] OriginalBTNsIMG;


    [Header("Popup tabs")]
    public GameObject TabsContainer;
    public GameObject[] Tabs;
    
    public void PickScreen(int index){
        ClearTabs();
        TabsContainer.SetActive(true);
        Tabs[index].SetActive(true);
    }

    void ClearTabs(){
        for (int i = 0; i < Tabs.Length; i++)
        {
            Tabs[i].SetActive(false);
        }
    }

    [Header("Character colours")]
    public GameObject[] CharacterModels;
    public Sprite[] CharacterModelSprites;

    public void CharacterCol(int index){
        // Resets all of the models to inactive
        for (int i = 0; i < CharacterModels.Length; i++)
        {
            // Reset all of the active models
            CharacterModels[i].SetActive(false);
        }

        // Activate a singular model
        CharacterModels[index].SetActive(true);
        // Change the original button image to the new selected sprite
        OriginalBTNsIMG[0].sprite = CharacterModelSprites[index];
    }

    [Header("Head selection")]
    public GameObject[] HeadModels;
    public Sprite[] HeadModelSprites;

    public void HeadSelect(int index){
        // Resets all of the models to inactive
        for (int i = 0; i < HeadModels.Length; i++)
        {
            // Reset all of the active models
            HeadModels[i].SetActive(false);
        }

        // Activate a singular model
        HeadModels[index].SetActive(true);
        // Change the original button image to the new selected sprite
        OriginalBTNsIMG[1].sprite = HeadModelSprites[index];
    }

    [Header("Eyes selection")]
    public GameObject[] EyesModels;
    public Sprite[] EyeModelSprites;

    public void EyeSelect(int index){
        // Resets all of the models to inactive
        for (int i = 0; i < EyesModels.Length; i++)
        {
            // Reset all of the active models
            EyesModels[i].SetActive(false);
        }

        // Activate a singular model
        EyesModels[index].SetActive(true);
        // Change the original button image to the new selected sprite
        OriginalBTNsIMG[2].sprite = EyeModelSprites[index];
    }
    
    [Header("Gloves selection")]
    public GameObject[] GlovesModels;
    public Sprite[] GlovesModelSprites;

    public void GloveSelect(int index){
        // Resets all of the models to inactive
        for (int i = 0; i < GlovesModels.Length; i++)
        {
            // Reset all of the active models
            GlovesModels[i].SetActive(false);
        }

        // Activate a singular model
        GlovesModels[index].SetActive(true);
        // Change the original button image to the new selected sprite
        OriginalBTNsIMG[3].sprite = GlovesModelSprites[index];
    }

    [Header("Mouth selection")]
    public GameObject[] MouthModels;
    public Sprite[] MouthModelSprites;

    public void MouthSelect(int index){
        // Resets all of the models to inactive
        for (int i = 0; i < MouthModels.Length; i++)
        {
            // Reset all of the active models
            MouthModels[i].SetActive(false);
        }

        // Activate a singular model
        MouthModels[index].SetActive(true);
        // Change the original button image to the new selected sprite
        OriginalBTNsIMG[4].sprite = MouthModelSprites[index];
        OriginalBTNsIMG[4].SetNativeSize();
    }

    [Header("Misc selection")]
    public GameObject[] MiscModels;
    public Sprite[] MiscModelSprites;

    public void MiscSelect(int index){
        // Resets all of the models to inactive
        for (int i = 0; i < MiscModels.Length; i++)
        {
            // Reset all of the active models
            MiscModels[i].SetActive(false);
        }

        // Activate a singular model
        MiscModels[index].SetActive(true);
        // Change the original button image to the new selected sprite
        OriginalBTNsIMG[5].sprite = MiscModelSprites[index];
        OriginalBTNsIMG[5].SetNativeSize();
    }
}