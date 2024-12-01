using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickStart : MonoBehaviour
{
    public bool Active;
    public GameObject Canvas1, Canvas2, Canvas3, Canvas4, Canvas5;

    void Awake(){
        if(Active){
            Canvas1.SetActive(true);
            Canvas2.SetActive(false);
            Canvas3.SetActive(false);
            Canvas4.SetActive(true);
            Canvas5.SetActive(false);

            Canvas4.SetActive(false);
        }
    }
}
