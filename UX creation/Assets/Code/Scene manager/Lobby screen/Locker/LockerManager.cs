using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LockerManager : MonoBehaviour
{
    [Header("Player in locker")]
    public GameObject PlayerTransform;
    public float RotationSpeed;

    void Update()
    {
        // While the mouse is clicked down and the mouse is within the region
        // Rotate the character by a set speed
        if(Input.GetMouseButton(0) && EventSystem.current.currentSelectedGameObject.name == "RenderTexture"){
            float h = RotationSpeed * Input.GetAxis("Mouse X");
            PlayerTransform.transform.Rotate(0, -h, 0);
        }
    }
}
