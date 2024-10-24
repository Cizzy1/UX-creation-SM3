using UnityEngine;

    /// <summary>
    /// 
    /// TODO: Reuseable button manager
    /// - Get all of the canvases.
    /// - Have set menus then users choose what screen they
    /// want to set a specif button to send to each screen.
    /// - Keep track of what screen is currently active
    /// 
    /// </summary>

public class CanvasManager : MonoBehaviour
{
    [Header("Put different screens here")]
    public GameObject[] Menus;

    [Header("Current active screen")]
    public bool BaseMenu_bool, Menu1_bool, Menu2_bool,
    Menu3_bool, Menu4_bool;

    [Header("Where do you want the back buttons to go?")]

    // The first base screen wont exist here as you cant really go any further back

    // AKA hard coded
    // MenuIndex_0 = Opening screen.    So by clicking that when they press the X button it returns them to that screen
    // MenuIndex_1 = Login screen.
    // MenuIndex_2 = Sign up.
    // MenuIndex_3 = Forgotten pass.
    // MenuIndex_4 = Loading.


    public Menu1_Return menu1_Return;
    public enum Menu1_Return
    {
        // user selects where the button will lead after being pressed
        MenuIndex_0, MenuIndex_2, MenuIndex_3, MenuIndex_4
    };

    // Hard coded this would send me back to 
    public Menu2_Return menu2_Return;
    public enum Menu2_Return
    {
        // user selects where the button will lead after being pressed
        MenuIndex_0, MenuIndex_1, MenuIndex_3, MenuIndex_4
    };

    void Awake(){
        // Make sure everything is disabled minus the first object within the
        for (int i = 0; i < Menus.Length; i++)
        {
            Menus[i].SetActive(false);
        }

        // This will set the first screen to be active
        Menus[0].SetActive(true);
        BaseMenu_bool = true;
    }
    void Update(){
        // should we check to see which screens are currently open?
        Debug.Log("Menu index currently active" + Menus.ToString());
    }

    public void Menu1Screen(){
        // Hide current screen and then open this screen

    }

    public void ReturnToPreviousScreen(){

    }

}
