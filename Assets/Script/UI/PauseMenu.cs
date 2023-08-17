using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject MenuPause;
    public CameraMovement CameraMove;
    public ActiveWeapon ActWeapon;
    private void Awake()
    {
        MenuPause.SetActive(false);
        CameraMove.enabled = true;
        ActWeapon.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        Cursor.visible = false;
    }
    private void Update()
    {
        OnPauseStart();
    }

    private void OnPauseStart()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            MenuPause.SetActive(true);
            CameraMove.enabled = false;
            ActWeapon.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
            Cursor.visible = true;
        }
    }

    public void GameContinue()
    {
        MenuPause.SetActive(false);
        CameraMove.enabled = true;
        ActWeapon.enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1f;
        Cursor.visible = false;
    }

    public void ExitInMenu()
    {
        GameContinue();
        SceneManager.LoadScene(0);
    }

    public void ButtonSettingsInPauseMenu()
    {
        SettingsMenu.SaveInfoForBack = false;
        SceneManager.LoadScene(2);
    }
}
