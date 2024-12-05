using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class RhuPassManager : MonoBehaviour
{
    public GameObject CurrentOBJ;
    public float RotationTime;

    // Update is called once per frame
    void Start()
    {
        Debug.Log("ajopdapsd");
        CurrentOBJ.transform.DOLocalRotate(new Vector3(0, 450, 0), RotationTime, RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);
    }
}
