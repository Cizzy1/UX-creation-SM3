using UnityEngine;

public class BackButton : MonoBehaviour
{
    // In editor simply add the current scene game object.
    // Then add the scene that you want to go back to, to
    // the GO variable.

    [Header("Screens")]
    public GameObject CurrentScreen;
    public GameObject TargetScreen;
    
    public void GoBack(){
        CurrentScreen.SetActive(false);

        TargetScreen.SetActive(true);
    }
}
