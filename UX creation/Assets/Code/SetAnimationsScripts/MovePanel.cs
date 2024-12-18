using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MovePanel : MonoBehaviour
{
    public GameObject BigBackBTN;
    public Image ScreenDarken;
    public float OriginX;
    public float MoveToX;
    public float TimeToMove;
    
    public void MoveMenu(){
        // This needs to fade in
        Debug.Log("PanelOpened");
        ScreenDarken.DOFade(1, .5f);
        transform.DOLocalMoveX(MoveToX, TimeToMove);
        SetBigBTNActive();
    }

    public void ResetPlacement(){
        // Needs to fade out
        Debug.Log("PanelClosed");
        ScreenDarken.DOFade(0, .5f);
        transform.DOLocalMoveX(OriginX, TimeToMove);
        SetBigBTNInactive();
    }

    public void SetBigBTNActive(){
        BigBackBTN.SetActive(true);
    }

    public void SetBigBTNInactive(){
        BigBackBTN.SetActive(false);
    }
}
