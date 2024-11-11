using UnityEngine;
using UnityEngine.UI;

public class SimpleEvents : MonoBehaviour
{
    [Header("Selection events")]
    public bool IsSelected = false;
    public Sprite SelectedGO;
    public Sprite NonSelectedGO;

    public void Selected(){
        // Once the text field for example has been selected the box will change
        // Colour to green from grey;

        // So for this one since its being selected. From referencing the UI board
        // I can see that this needs to go to green which is it being selected.

        // I don't think there is and easier way other than just switching them out.
        GetComponent<Image>().sprite = SelectedGO;

        //Debug.Log("Box selected");

        IsSelected = true;
    }

    public void Deselect(){
        // Once the text field for example has been selected the box will change
        // Colour to green from grey;
        GetComponent<Image>().sprite = NonSelectedGO;

        //Debug.Log("Box deselected");
        IsSelected = false;
    }
}
