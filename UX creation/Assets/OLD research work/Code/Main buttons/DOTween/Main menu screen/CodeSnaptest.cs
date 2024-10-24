using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CodeSnaptest : MonoBehaviour
{
    public float FadeOut;
    public Color ChoosenColour;
    public GameObject UIText;
    public Image UIImage;

    void Start()
    {
        // Takes current position and moves it to the Vector3 within the DOMove()
        //transform.DOMove(new Vector3(0, 1.5f, 0), 5);



        // This will scale the object from its current size of 1, 1, 1 to 2, 2, 2
        // over 5 seconds.
        //transform.DOScale(new Vector3(2,2,2), 5);



        // Exmaple for text objects
        // Over 5 seconds will change the colour from the current colour to the new
        // colour. In this case being "ChoosenColour".
        
        // Changes colour of text
        //UIText.GetComponent<TMP_Text>().DOColor(ChoosenColour, 5);

        // Changes colour of image
        //UIImage.GetComponent<Image>().DOColor(ChoosenColour, 5);
    


        CodeSnapDOTWeen();
    }

    void CodeSnapDOTWeen(){
        UIImage.GetComponent<Image>().DOFade(FadeOut, 5);
    }
}
