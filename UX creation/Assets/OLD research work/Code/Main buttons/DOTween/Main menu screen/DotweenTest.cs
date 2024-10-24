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
        // Generates a random colour
        RandCol = Random.ColorHSV();

        // Generates another radom colour
        AnotherRandCol = Random.ColorHSV();

        // Generates yet another random colour but for the text
        TextRandCol = Random.ColorHSV();

        // Changing the text colour every frame (this does not look good at all)
        HeaderText.DOColor(TextRandCol, 0f);

        // Changing the image background colour every frame (this also does not look good at all)
        uiBackground.DOColor(RandCol, 0f);
        
        for(int i = 0; i < FlashButtons.Length; i++)
        {
            // for every button change its colour
            flashButtons[i].DOColor(AnotherRandCol, 0f);
        }

        for(int F = 0; F < SpinImage.Length; F++)
        {
            // for every image it will spin the image a full 360 and continue to loop whilst also shaking its current pos
            SpinImage[F].DOLocalRotate(new Vector3(0,360,0), Random.Range(0.1f, .6f),RotateMode.FastBeyond360).SetLoops(-1);
            SpinImage[F].DOShakePosition(Random.Range(.2f, 1), Random.Range(5, 100), 5, 5);
        }

    }
}