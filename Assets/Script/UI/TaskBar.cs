using UnityEngine;
using TMPro;

public class TaskBar : MonoBehaviour
{
    [SerializeField] private TMP_Text TaskBarText;
    [SerializeField] private GameObject TaskBarPanel;

    private int EnableTowers;

    private void Start()
    {
        TaskBarPanel.SetActive(true);
    }

    private void Update()
    {
        EnableTowers = TowerTrigger.OnGlassStage;
        if (SaveGameStage.SaveStageGame != 0 && TowerTrigger.OnGlassStage <= 3)
        {
            TaskBarText.text = $"Enable Towers {EnableTowers}/4";
        }
        if (SaveGameStage.SaveStageGame == 0)
            TaskBarText.text = "Find info";
        if(TowerTrigger.OnGlassStage == 4)
        {
            TaskBarText.text = "Sneak into headquaters";
        }

    }
}
