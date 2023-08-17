using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerHP : MonoBehaviour
{
    public static int HPPlayer;
    public TMP_Text PlayerHPText;

    private void Awake()
    {
        HPPlayer = 100;
        StartCoroutine(ReturnHP());
    }

    private void Update()
    {
        if (HPPlayer == 0)
        {
            SaveGameStage.SaveGame();
            SceneManager.LoadScene(1);
        }
        PlayerHPText.text = "HP:" + PlayerHP.HPPlayer;
    }

    private IEnumerator ReturnHP()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            if (HPPlayer <= 99)
            {
                HPPlayer++;
            }
        }
    }
}
