using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerManager : MonoBehaviour
{
    [Header("Player in locker")]
    public GameObject PlayerTransform;
    public float RotationSpeed;

    void Update()
    {
        if(Input.GetMouseButton(0)){
            float h = RotationSpeed * Input.GetAxis("Mouse X");
            PlayerTransform.transform.Rotate(0, -h, 0);
        }
    }
}
