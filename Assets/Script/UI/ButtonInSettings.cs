using UnityEngine;

public class ButtonInSettings : MonoBehaviour
{
    public void DeleteSaveGame()
    {
        SaveGameStage.SaveStageGame = 0;
        TowerTrigger.OnGlassStage = 0;
        SaveGameStage.SaveGame();
    }

    public void OpenUpInItchIo()
    {
        Application.OpenURL("https://unsimple-pixel.itch.io/");
    }
}
