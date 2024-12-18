using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class MapNavigation : MonoBehaviour, IScrollHandler
{
    /// <summary>
    /// What does this need to do
    /// 
    /// Easy part:
    /// - Navigate around the map
    /// - Bounding area to not go out of the map
    /// 
    /// Scrap above I found a farr easier method than coding it
    /// the link to said tut is here -> https://youtu.be/BFX3FpUnoio?si=IbVyv4Z9MP5W9VbU
    /// </summary>
     
    Vector3 InitialScale;
    public float zoomSpeed = .1f;
    public float MaxZoom = 10f;

    void Awake(){
        InitialScale = transform.localScale;
    }

    public void OnScroll(PointerEventData eventData)
    {
        //Debug.Log(eventData.scrollDelta);
        // This takes the scroll up and down data when the mouse is above the rect area
        // This is then multiplied by the set zoomSpeed
        var delta = Vector3.one * (eventData.scrollDelta.y * zoomSpeed);

        var desiredScale = transform.localScale + delta;

        desiredScale = ClampDesiredScale(desiredScale);

        transform.localScale = desiredScale;       
    }

    Vector3 ClampDesiredScale(Vector3 desiredScale){

        desiredScale = Vector3.Max(InitialScale, desiredScale);
        desiredScale = Vector3.Min(InitialScale * MaxZoom, desiredScale);

        return desiredScale;
    }
}
