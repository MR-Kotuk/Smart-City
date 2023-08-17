using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameTR : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "EndGame")
        {
            StartCoroutine(EndGameScene());
        }
    }

    private IEnumerator EndGameScene()
    {
        SceneManager.LoadScene(3);
        yield return new WaitForSeconds(2f); 
        SceneManager.LoadScene(0);
    }
}
