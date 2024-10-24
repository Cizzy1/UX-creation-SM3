using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class CardManager : MonoBehaviour,IPointerEnterHandler,IPointerExitHandler 
{
    public List<Item> CardStats = new List<Item>();

    public TMP_Text HeaderText;
    public Image CatImage;
    public TMP_Text DescriptionText; 

    void Start()
    {
        CardApplier();
    }

    public void ChangeCard(){
        //Button click to change out the card
        CardApplier();
    }

    void CardApplier(){
        //Choose random item
        Item RandomCardStats = CardStats[Random.Range(0, CardStats.Count)];

        //Setting card up
        HeaderText.text = RandomCardStats.ItemHeader.ToString();
        CatImage.overrideSprite = RandomCardStats.Icon;
        DescriptionText.text = RandomCardStats.ItemDescription.ToString();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //eventData.pointerEnter.gameObject
    } 

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }



    //i wish i was as good as pete at programming
}
