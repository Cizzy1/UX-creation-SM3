using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class BottomButtonsAnimations : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool IsActive;

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Debug.Log("Hovering" + eventData.pointerEnter.gameObject.name);
        //NudgeAnim();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //Debug.Log("Stopped hovering" + eventData.pointerEnter.gameObject.name);
        //DefaultPos();
    }

    [Header("Animations")]
    public float DefaultYPos;
    public float NudgeYPos;
    public float ActiveYPos;

    public void DefaultPos(){
        transform.DOLocalMoveY(DefaultYPos, 0.5f);
    }

    public void SnapDefaultPos(){
        transform.DOLocalMoveY(DefaultYPos, 0f);
    }

    void NudgeAnim(){
        if(!IsActive){
            transform.DOLocalMoveY(NudgeYPos, 0.5f);
        }
    }

    public void ActiveAnim(){
        transform.DOLocalMoveY(ActiveYPos, 0.5f);
    }
}
