using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class CloseGO : MonoBehaviour
{
    public void CloseOBJ(){
        StartCoroutine(CloseAfterTime());

    }

    IEnumerator CloseAfterTime(){
        transform.DOScale(Vector3.zero, .5f);
        yield return new WaitForSeconds(.5f);
        gameObject.SetActive(false);
    }
}
