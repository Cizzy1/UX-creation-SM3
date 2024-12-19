using System.Collections;
using DG.Tweening;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public GameObject ShopParent;
    public Vector3 DistanceToMoveUp;
    public Vector3 DistanceToMoveDown;
    bool CanScroll;
    public int ScrollInt;
    void Start()
    {
        CanScroll = true;

        // 0 is the top of the screen. 4 is the bottom of the screen
        ScrollInt = 0;

        MovePanel();
    }

    void Update(){
        // Scrol up
        if(Input.GetAxisRaw("Mouse ScrollWheel") > 0 && CanScroll && ScrollInt > 0){
            CanScroll = false;
            Debug.Log("Scrolled Up");
            // Going further to the top so the max is 4 the min is the 0 so going up
            // takes away
            ScrollInt --;
            // Panel animation
            MovePanel();
            // Wait 1s
            StartCoroutine(ScrollDelay());
        }

        // Scroll down
        // can't do anymore than 4 scrolls down
        if(Input.GetAxisRaw("Mouse ScrollWheel") < 0 && CanScroll && ScrollInt < 4){
            CanScroll = false;
            Debug.Log("Scrolled Down");

            // Need to increase the int
            ScrollInt ++;


            MovePanel();

            StartCoroutine(ScrollDelay());
        }
    }

    // Adds a delay so that the animation can at least play
    IEnumerator ScrollDelay(){
        yield return new WaitForSeconds(1);
        CanScroll = true;
    }

    [Header("Test")]
    public float[] PointsToMoveTo;

    void MovePanel(){
        // The scroll int is the next point it needs to move to
        float NextPoint = PointsToMoveTo[ScrollInt];
        // Move the parent to the next point over 1s
        ShopParent.transform.DOLocalMoveY(NextPoint, 1);
    }
}