using DG.Tweening;
using UnityEngine;

public class CodeSnaptest : MonoBehaviour
{
    void Start()
    {
        // Takes current position and moves it to the Vector3 within the DOMove()
        transform.DOMove(new Vector3(2, 0, 2), 5);
    }
}
