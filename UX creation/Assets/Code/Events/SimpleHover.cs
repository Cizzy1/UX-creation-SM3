using UnityEngine;
using UnityEngine.EventSystems;

public class SimpleHover : MonoBehaviour, IPointerEnterHandler
{
    [Header("Elements")]
    public GameObject NoneHover;
    public GameObject Hovered;

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse enter");   
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Mouse exit");
    }
}
