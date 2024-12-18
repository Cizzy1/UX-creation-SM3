using UnityEngine;
using UnityEngine.EventSystems;

public class MapMarker : MonoBehaviour
{
    public GameObject MapMarkerGO;

    void Update(){

        if(Input.GetMouseButtonDown(0)){
            GameObject SelectedGO = EventSystem.current.currentSelectedGameObject;

            // If the currently selected object is named Map move the cursor to the 
            // mouse position on the UI.
            if(SelectedGO != null && SelectedGO.name == "Map")
            {
                //Debug.Log("Something happened?");
                MapMarkerGO.SetActive(true);
                // Move marker to the mouse pos.
                MapMarkerGO.transform.position = Input.mousePosition;     
            }
            // If the selected object is the Mouse pointer itself disable the mouse pointer
            else if(SelectedGO != null && SelectedGO.name == "MousePointer")
            {
                //Debug.Log("Something else happened?");
                // Disable the
                MapMarkerGO.SetActive(false);
            }
        }
    }
}