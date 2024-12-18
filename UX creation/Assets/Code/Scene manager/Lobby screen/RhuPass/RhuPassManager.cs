using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class RhuPassManager : MonoBehaviour
{
    [Header("Item rotation")]
    public GameObject CurrentOBJ;
    public float RotationTime;

    // Update is called once per frame
    void Start()
    {
        //Debug.Log("ajopdapsd");
        // Once opening the screen the character will start to rotate around in a circle motion until the player closes the screen
        CurrentOBJ.transform.DOLocalRotate(new Vector3(0, 450, 0), RotationTime, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);

        if(!HasGenerated){
            GenerateItems();
        }
    }

    [Header("Items to generate")]
    bool HasGenerated;
    List<int> ItemsInUse = new List<int>();
    public GameObject ContentGO;
    public GameObject ItemsTemplate;
    public RhuPassItems rhuPassItems;
    public int SeasonLength;

    void GenerateItems(){
        // Why do this?
        // Doing this the same way ish as the Quests means that this can be added to easily
        // Without the scriptable objects creating a bunch of new prefabs would be awful and
        // this is a future way of going around 
        HasGenerated = true;
        for (int i = 0; i < SeasonLength; i++)
        {
            GameObject ItemObject = Instantiate(ItemsTemplate, ContentGO.transform);

            ItemObject.transform.Find("Tier").GetComponent<TMP_Text>().text = "Tier " + rhuPassItems.items[i].TierNumber;
            ItemObject.transform.Find("ItemName").GetComponent<TMP_Text>().text = rhuPassItems.items[i].ItemName;
            ItemObject.transform.Find("ItemLocation").GetComponent<TMP_Text>().text = rhuPassItems.items[i].Description;

            ItemObject.transform.Find("BG").GetComponent<Button>().onClick.AddListener(() => OnClick());

            ItemObject.transform.Find("BG").GetComponent<Button>().onClick.AddListener(() => ChangingOutItem(i));
            
            GameObject IconToSpawn = Instantiate(rhuPassItems.items[i].ItemIcon, ItemObject.transform.Find("IconParent").transform);

            if(i == 0){
                Grow(ItemObject);
            }
        }
    }


    GameObject CurrentSelection;

    public void OnClick(){
        // Use event system to figure out what has been clicked
        if(CurrentSelection != null)
        {
            Shrink(CurrentSelection);
        }
        GameObject nextSelectedOBJ = EventSystem.current.currentSelectedGameObject;
        Grow(nextSelectedOBJ);
    }

    void Grow(GameObject GO){
        GO.GetComponentInChildren<Button>().interactable = false;
        GO.transform.parent.DOScale(1.1f, .5f);
        
        CurrentSelection = GO;
    }

    void Shrink(GameObject GO){
        GO.GetComponentInChildren<Button>().interactable = true;
        GO.transform.parent.DOScale(1f, .5f);
    }

    void ChangingOutItem(int index){
        
    }

    // Changing out the items

    [Header("Switching items out")]
    public GameObject ItemSpawnPoint;
    void ShowItem(){
        // Check the index of this within the Content obj (parent of the button)
        // Then check parent index and see what index it is to the scriptables
        // Then get the scriptable match and then get from its variable the item
        // to show. Then instantiate the object in the scene on the correct point


    }

    void HideItem(){

    }

    
}
