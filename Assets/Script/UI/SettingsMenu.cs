using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    public static bool SaveInfoForBack = true;

    public void ButtonBackInSettingsMenu()
    {
        if (SaveInfoForBack == true)
            SceneManager.LoadScene(0);
        else if (SaveInfoForBack == false)
            SceneManager.LoadScene(1);
    }
}
