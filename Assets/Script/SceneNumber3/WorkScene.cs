using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WorkScene : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(WorkSceneInGame(9f));
    }

    private IEnumerator WorkSceneInGame(float wait)
    {
        yield return new WaitForSeconds(wait);
        SceneManager.LoadScene("MenuScene");
    }
}
