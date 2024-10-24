using DG.Tweening;
using UnityEngine;

public class SimpleAnimations : MonoBehaviour
{
    public float maxScaleSize;

    void OnEnable(){
        
        transform.localScale = new Vector3(1, 1, 1);
        transform.DOScale(maxScaleSize, 1).SetEase(Ease.InSine).SetLoops(-1, LoopType.Yoyo);
    }

    void OnDisable(){
        DOTween.Kill(transform);
    }
}
