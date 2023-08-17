using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStageTR : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Water")
        {
            SaveGameStage.SaveGame();
            SceneManager.LoadScene(1);
        }
            
        if (other.tag == "GameStageTR")
        {
            SaveGameStage.SaveStageGame++;
            Debug.Log(SaveGameStage.SaveStageGame);
            Destroy(other);
        }
    }
}
