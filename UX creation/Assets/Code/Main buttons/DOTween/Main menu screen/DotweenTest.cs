using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;

public class DotweenTest : MonoBehaviour
{
    public GameObject Background;
    private Image uiBackground;
    //
    public GameObject[] FlashButtons;
    private Image[] flashButtons = new Image[3];
    //
    public Transform[] SpinImage = new Transform[5];
    public TMP_Text HeaderText;
    //
    private Color RandCol;
    private Color AnotherRandCol;
    private Color TextRandCol;

    void Start()
    {
        uiBackground = Background.GetComponent<Image>();

        for(int i = 0; i < FlashButtons.Length; i++)
        {
            flashButtons[i] = FlashButtons[i].GetComponent<Image>();
        }
    }

    void Update()
    {
        RandCol = Random.ColorHSV();
        AnotherRandCol = Random.ColorHSV();
        TextRandCol = Random.ColorHSV();

        HeaderText.DOColor(TextRandCol, 0f);

        uiBackground.DOColor(RandCol, 0f);
        
        for(int i = 0; i < FlashButtons.Length; i++)
        {
            flashButtons[i].DOColor(AnotherRandCol, 0f);
        }

        for(int F = 0; F < SpinImage.Length; F++)
        {
            SpinImage[F].DOLocalRotate(new Vector3(0,360,0), Random.Range(0.1f, .6f),RotateMode.FastBeyond360).SetLoops(-1);
            SpinImage[F].DOShakePosition(Random.Range(.2f, 1), Random.Range(5, 100), 5, 5);
        }

    }

    void CodeSnapDOTween(){
        // Takes current position and moves it to the Vector3 within the DOMove()
        transform.DOMove(new Vector3(1, 1, 1), 5);
    }
}
