using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    private void Awake()
    {
        SettingsMenu.SaveInfoForBack = true;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void ButtonExitInMenu()
    {
        Application.Quit();
    }
    public void ButtonSettingsInMenu()
    {
        SceneManager.LoadScene(2);
    }
    public void ButtonPlayInMenu()
    {
        SceneManager.LoadScene(1);
    }
}
