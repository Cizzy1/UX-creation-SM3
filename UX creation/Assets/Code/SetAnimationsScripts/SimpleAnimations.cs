using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class SimpleAnimations : MonoBehaviour
{
    [Header("Scale up open animation")]
    public bool OpenWithScale;
    public Vector3 OpenToScale;
    public float OpenScaleTime;
    

    [Header("Scale down close animation")]
    public bool CloseWithScale;
    public float CloseScaleTime;


    [Header("Looping sine scale")]
    public bool LoopScale;
    public float maxScaleSize;

    
    [Header("Looping sine scale")]
    public Color MaxAlpha;
    public Color MinAlpha;
    public float timeToFade;
    
    
    [Header("Move to animation")]
    public bool MoveOnStart;
    public RectTransform Panel;
    public Vector2 HiddenPos;
    public Vector2 UnHiddenPos;
    public float TimeToMove;
    public bool isToggleOn = true;
    
    #region On enable & on disable
    void OnEnable(){

        if(LoopScale){
            LoopScaleAnimation();
        }

        if(OpenWithScale){
            OpenAndScale();
        }

    }

    void OnDisable(){
        DOTween.Kill(transform);
    }
    #endregion

    #region Looping animations
    public void LoopScaleAnimation(){
        transform.localScale = new Vector3(1, 1, 1);
        transform.DOScale(maxScaleSize, 1).SetEase(Ease.InSine).SetLoops(-1, LoopType.Yoyo);
    }

    #endregion

    public void OpenAndScale(){
        transform.localScale = Vector3.zero;
        transform.DOScale(OpenToScale, OpenScaleTime);
    }

    public void CloseAnimation(){

        // Over time the object will go from its current scale. I could only guess of Vector3(1, 1, 1) to
        // Vector3(0, 0, 0) over whatever value is in CloseScaleTime;
        transform.DOScale(Vector3.zero, CloseScaleTime);

        // Saying this will be on the object that you want closing might as well put the disabling of the object there as well
        //gameObject.SetActive(false);
        gameObject.transform.parent.gameObject.SetActive(false);
    }

    public void CloseAnimationWithoutParent(){
        transform.DOScale(Vector3.zero, CloseScaleTime);

        gameObject.SetActive(false);
    }

    public void FadeOn(){
        GetComponent<Image>().DOColor(MaxAlpha, timeToFade);
    }
    public void FadeBack(){
        GetComponent<Image>().DOColor(MinAlpha, timeToFade);
    }

    #region Moving panel
    public void PanelMoving(bool isPanelOpen){
        // if Panel is currently hidden move to be none hidden
        if(isPanelOpen){
            Panel.DOAnchorPos(UnHiddenPos, TimeToMove);
            Debug.Log("Opened");
        }
        else{   
            Panel.DOAnchorPos(HiddenPos, TimeToMove);
            Debug.Log("Closed");
        }
        isToggleOn = isPanelOpen;
    }
    #endregion
}
