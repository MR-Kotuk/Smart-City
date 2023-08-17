using System.Collections;
using UnityEngine;

public class SaveGameStage : MonoBehaviour
{
    public static int SaveStageGame = 0;

    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject LoadingCube;
    [SerializeField] private GameObject TutorialCube;
    [SerializeField] private GameObject[] StageTR = new GameObject[6];

    [SerializeField] private Vector3[] StagePoint = new Vector3[7];

    private void Start()
    {
        TutorialCube.SetActive(false);
        if (SaveStageGame == 0)
            TutorialCube.SetActive(true);

        LoadingCube.SetActive(true);
        SaveStageGame = PlayerPrefs.GetInt("SaveGameStage");
        TowerTrigger.OnGlassStage = PlayerPrefs.GetInt("GlassTowerStage");
        FindPlayerPos();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SaveGame();
        }
        if (Input.GetKey(KeyCode.Return))
            TutorialCube.SetActive(false);
    }

    public static void SaveGame()
    {
        PlayerPrefs.SetInt("GlassTowerStage", TowerTrigger.OnGlassStage);
        PlayerPrefs.SetInt("SaveGameStage", SaveStageGame);
    }
    private void FindPlayerPos()
    {
        switch (SaveStageGame)
        {
            case 0:
                StartCoroutine(TransformPlayerPos(StagePoint[0], null));
                break;
            case 1:
                StartCoroutine(TransformPlayerPos(StagePoint[1], StageTR[0]));
                break;
            case 2:
                StartCoroutine(TransformPlayerPos(StagePoint[2], StageTR[1]));
                break;
            case 3:
                StartCoroutine(TransformPlayerPos(StagePoint[3], StageTR[2]));
                break;
            case 4:
                StartCoroutine(TransformPlayerPos(StagePoint[4], StageTR[3]));
                break;
            case 5:
                StartCoroutine(TransformPlayerPos(StagePoint[5], StageTR[4]));
                break;
            case 6:
                StartCoroutine(TransformPlayerPos(StagePoint[6], StageTR[5]));
                break;
        }
    }

    private IEnumerator TransformPlayerPos(Vector3 SavePosition, GameObject DestoyedObj)
    {
        Destroy(DestoyedObj);   

        yield return new WaitForSeconds(4f);
        LoadingCube.SetActive(false);
        Player.transform.position = SavePosition;
    }
}
