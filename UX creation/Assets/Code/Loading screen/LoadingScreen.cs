using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreen : MonoBehaviour
{
    /// <summary>
    /// 
    /// This script will be using images set to filled rather than the
    /// usual sliders. This is just a preference thing and also allows
    /// me to correctly use the provided images without distortion.
    /// 
    /// </summary>
    
    public Image LoadingBar;
    public TMP_Text LoadingText;

    void Start()
    {
        // Sets the bar fill amount to 0
        LoadingBar.fillAmount = 0;
        // Sets the text on the bar to also 0 and formats it with %
        LoadingText.text = "0%";

        // Looping process that starts after .25s and then repeats "RandomAmount"
        // every random time between .1s - .5s. This gives the loading bar a slow
        // incremental increase.
        InvokeRepeating("RandomAmount", .25f, Random.Range(.1f,.5f));
    }

    void RandomAmount(){
        // Generating a random. This random number is then divided by 100 as
        // fillAmount is a range only between 0-1 not 0-100 like a slider.
        // This value cannot also be change through a MaxValue.
        float RandomNum = Random.Range(1f, 4f) / 100f;
        
        // Taking the randomly generated number from above and updating the
        // fillAmount.
        LoadingBar.fillAmount += RandomNum;

        // Updating the text to be the same as the RandomNum but also *100 as
        // for example RandomNum if generated a 4 it would be 0.04 so it needs
        // to be *100 so that it makes sense in the context of the loading bar
        LoadingText.text = (LoadingBar.fillAmount * 100).ToString("0") + "%";

        // Check if the max value of the fillAmount is met
        if(LoadingBar.fillAmount == 1f){
            // IF yes load "MainScreen"
            SceneManager.LoadScene("MainScreen");
        }
    }
}
